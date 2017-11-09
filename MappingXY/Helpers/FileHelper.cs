using MappingXY.DefaultItems;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MappingXY.Helpers
{
    class FileHelper
    {
        //filterIndex
        //    1 - txt
        //    2 - excel
        //    3 - gpx

        public void WriteToFile(int filterIndex, string path,string[] xInput, string[] yInput)
        {

            switch (filterIndex)
            {
                
                case 1:
                    StreamWriter stWriter = new StreamWriter(path);
                    for (int i = 0; i < xInput.Length; i++)
                    {
                        stWriter.WriteLine(xInput[i] + ":" + yInput[i]);
                    }
                    stWriter.Close();
                    break;
                case 2:
                    Stream stream= new FileStream(path,FileMode.Create);
                    using (ExcelPackage excel = new ExcelPackage(stream))
                    {
                        var worksheet=excel.Workbook.Worksheets.Add("Координаты");
                        for (int i = 0; i < xInput.Length; i++)
                        {
                            worksheet.Cells["A" + (i + 1)].Value = xInput[i];
                            worksheet.Cells["B" + (i + 1)].Value = yInput[i];
                        }
                        excel.Save();    
                    }
                    stream.Close();
                    break;
                case 3:
                    XmlWriter writer = XmlWriter.Create(path);
                    writer.WriteStartDocument();
                    //head
                    writer.WriteStartElement("gpx", "http://www.topografix.com/GPX/1/1");
                        writer.WriteAttributeString("creator", "TFI RK");
                        writer.WriteAttributeString("version", "1.1");
                        writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                        writer.WriteAttributeString("xsi", "schemaLocation", null, "http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd");
                    //metadata tag
                        writer.WriteStartElement("metadata");
                            writer.WriteStartElement("link");
                                writer.WriteStartAttribute("href");
                                    writer.WriteString("http://www.agiks.ru/");
                                writer.WriteEndAttribute();
                                writer.WriteElementString("text", "TFI RK");
                            writer.WriteEndElement();
                            writer.WriteElementString("time", DateTime.Now.ToString());
                        writer.WriteEndElement();
                    //wpt tags
                    for (int i=0;i<xInput.Length;i++){
                        writer.WriteStartElement("wpt");
                            writer.WriteStartAttribute("lat");
                                writer.WriteString(xInput[i]);
                            writer.WriteEndAttribute();
                            writer.WriteStartAttribute("lon");
                                writer.WriteString(yInput[i]);
                            writer.WriteEndAttribute();
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    //writer.WriteString("</gpx>");
                    writer.WriteEndDocument();
                    writer.Close();
                    break;
                default: break;
            }
        }

        public List<string[]> LoadFromFile(int filterIndex,string path)
        {
            List<string[]> points = new List<string[]>();
            switch (filterIndex)
            {
                case 1:
                    StreamReader stReader = new StreamReader(path);
                    while (!stReader.EndOfStream)
                    {
                        string[] line = stReader.ReadLine().Split(':');
                        points.Add(new string[] { line[0], line[1] });
                    }
                    stReader.Close();
                    break;
                case 2:
                    Stream stream;
                    try
                    {
                        stream= new FileStream(path,FileMode.Open);
                    }
                    catch (IOException e)
                    {
                        //ImaginaryMessage im = new ImaginaryMessage();
                        //im.ShowMessage(e.Message);
                        throw e;
                    }
                    using (ExcelPackage excel = new ExcelPackage(stream))
                    {
                        var worksheet=excel.Workbook.Worksheets.First();
                        for (int i = 0; true; i++)
                        {
                            string xInput = worksheet.Cells["A" + (i + 1)].Text;
                            string yInput = worksheet.Cells["B" + (i + 1)].Text;
                            if (xInput == "" && yInput == "")
                            {
                                break;
                            }
                            else
                            {
                                points.Add(new string[] { xInput, yInput });
                            }
                        }   
                    }
                    stream.Close();
                    break;
                case 3:
                    using (XmlReader xmlReader = XmlReader.Create(path))
                    {
                        string lat, lon = "";
                        while (xmlReader.Read())
                        {
                            xmlReader.ReadToFollowing("wpt");
                            if (xmlReader.IsStartElement())
                            {
                                lat = xmlReader.GetAttribute("lat");
                                lon = xmlReader.GetAttribute("lon");
                                points.Add(new string[] { lat, lon });
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            return points;
        }
    }
}
