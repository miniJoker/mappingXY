using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj4Net;
using GeoAPI.Geometries;
using System.Xml;
using System.Globalization;
using System.IO;
using OfficeOpenXml;

namespace MappingXY.Helpers
{
    class CoordinateHelper
    {
        private static CoordinateReferenceSystem selectedSystem;
        private static CoordinateReferenceSystem geographSystem;
        private static CoordinateReferenceSystemFactory crFac = new CoordinateReferenceSystemFactory();
        private static CoordinateTransformFactory ctFac = new CoordinateTransformFactory();
        private static ICoordinateTransform trans;

        private static Dictionary<string,string> refSystems = new Dictionary<string,string>();
        public string[] GetRefSystems(){
            string[] keys= new string[refSystems.Count];
            keys = refSystems.Select(x=>x.Key).ToArray();
            return keys;
        }

        public CoordinateHelper()
        {
            using (Stream stream = new FileStream("./systems.xlsx", FileMode.Open))
            {
                string proj4,dX,name, dY, cM = "";
                using (ExcelPackage excel = new ExcelPackage(stream, "Fgh8DjhEashKl5"))
                {
                    var worksheet = excel.Workbook.Worksheets.First();
                    for (int i = 2; true; i++)
                    {
                        name = worksheet.Cells["A" + i].Text;
                        if (name == "")
                        {
                            break;
                        }
                        else
                        {
                            dX = worksheet.Cells["B" + i].Text;
                            dY = worksheet.Cells["C" + i].Text;
                            cM = worksheet.Cells["D" + i].Text;
                            proj4 = "+proj=tmerc +lat_0=0 +lon_0=" + cM + " +k=1 +x_0=" + dX + " +y_0=" + dY + " +ellps=krass +towgs84=23.57,-140.95,-79.8,0,0.35,0.79,-0.22 +units=m +no_defs";
                            refSystems.Add(name, proj4);
                        }
                    }
                    
                } 
            }
            geographSystem = crFac.CreateFromParameters("wsg84", "+proj=longlat +ellps=WGS84 +datum=WGS84 +no_defs");
        }

        public List<string[]> transformCoords(string system,List<string[]> points, string type) 
        {
            initRefSystem(system);
            List<string[]> returnList=new List<string[]>();
            if (type.Equals("reverse"))
            {
                trans = ctFac.CreateTransform(geographSystem, selectedSystem);
            }
            else
            {
                trans = ctFac.CreateTransform(selectedSystem, geographSystem);
            }
            NumberFormatInfo nFormatInfo = (NumberFormatInfo) NumberFormatInfo.CurrentInfo.Clone();
            nFormatInfo.NumberDecimalSeparator = ",";
            foreach (string[] sPoint in points)
            {
                double[] dPoint = new double[] { Convert.ToDouble(sPoint[0], nFormatInfo), Convert.ToDouble(sPoint[1], nFormatInfo) };
                double[] newPoint = calcCoords(dPoint, type);
                returnList.Add(new string[] {newPoint[0].ToString(nFormatInfo),newPoint[1].ToString(nFormatInfo)});
            }
            return returnList;
        }

        private void initRefSystem(string system)
        {
            selectedSystem = crFac.CreateFromParameters(system, refSystems[system]);
        }

        private double[] calcCoords(double[] point, string type)
        {
            Coordinate coordTrg = new Coordinate();
            //coordTrg=trans.Transform(new Coordinate(point[0], point[1]), coordTrg as Coordinate);
            double[] returnPoint = new double[2];
            if (type.Equals("reverse"))
            {
                coordTrg = trans.Transform(new Coordinate(point[0], point[1]), coordTrg as Coordinate);
                returnPoint[0] = Math.Round(coordTrg.Y, 2);
                returnPoint[1] = Math.Round(coordTrg.X, 2);
            }
            else
            {
                coordTrg = trans.Transform(new Coordinate(point[1], point[0]), coordTrg as Coordinate);
                returnPoint[0] = Math.Round(coordTrg.X,10);
                returnPoint[1] = Math.Round(coordTrg.Y,10);
            }
            return returnPoint;
        }

    }
}
