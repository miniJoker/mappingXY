using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MappingXY.DefaultItems;
using System.IO;
using MappingXY.Helpers;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MappingXY
{
    public partial class MainForm : Form
    {
        private List<TextBox> listXInput=new List<TextBox>();
        private List<TextBox> listYInput = new List<TextBox>();
        private List<TextBox> listXResult = new List<TextBox>();
        private List<TextBox> listYResult = new List<TextBox>();
        private static CoordinateHelper coordHelper = new CoordinateHelper();

        public MainForm()
        {
            InitializeComponent();
            InitToolTipText();
            initInputSystem();
            for (int i = 1; i < 5; i++)
            {
                AddNewXYFields(i);
            }
        }

        private void initInputSystem() {
            string[] systems = coordHelper.GetRefSystems();
            this.InputSystem.Items.AddRange(systems);
        }

        private void AddFieldButton_Click(object sender, EventArgs e)
        {
            int index = this.InputTableLayout.RowCount-1;
            AddNewXYFields(index);
        }

        private void AddNewXYFields(int index)
        {
            TableLayoutPanel[] tableColl = new TableLayoutPanel[2] { this.InputTableLayout, this.OutputTableLayout };
            string type = "Input";
            foreach (TableLayoutPanel table in tableColl)
            {
                Label label = new DefaultLabel(type + index, index + ":");
                TextBox xTextBox = new DefaultInput("X" + type + index, this.ImaginaryMessage);
                //xTextBox.Text = xTextBox.Name;
                TextBox yTextBox = new DefaultInput("Y" + type + index, this.ImaginaryMessage);
                //yTextBox.Text = yTextBox.Name;
                table.Controls.Add(label, 0, index - 1);
                if (type.Equals("Input"))
                {
                    listXInput.Add(xTextBox);
                    listYInput.Add(yTextBox);
                    table.Controls.Add(xTextBox, 1, index - 1);
                    table.Controls.Add(yTextBox, 2, index - 1);
                }
                else
                {
                    listXResult.Add(xTextBox);
                    listYResult.Add(yTextBox);
                    table.Controls.Add(xTextBox, 2, index - 1);//поменял 1 и 2 местами
                    table.Controls.Add(yTextBox, 1, index - 1);//
                }
                table.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                table.RowCount++;
                type = "Result";
            }
        }

        private void CleanFormButton_Click(object sender, EventArgs e)
        {
            DropTables();
            for (int i = 0; i < 4; i++)
            {
                AddNewXYFields(i + 1);
            }
        }

        private void DropTables() {
            TableLayoutPanel[] tableColl = new TableLayoutPanel[2] { this.InputTableLayout, this.OutputTableLayout };
            foreach (TableLayoutPanel table in tableColl)
            {
                table.RowCount = 2;
                table.Controls.Clear();
                table.Height = 295;
            }
            listXInput.Clear();
            listYInput.Clear();
            listXResult.Clear();
            listYResult.Clear();
        }

        private void InitToolTipText()
        {
            this.toolTip.SetToolTip(AddFieldButton, "Добавить на форму пару полей для ввода координат");
            this.toolTip.SetToolTip(CleanFormButton, "Вернуть форму в начальное состояние");
            this.toolTip.SetToolTip(RunButton, "Выполнить пересчет координат");
            this.toolTip.SetToolTip(SaveDataButton, "Сохранить введеные данные в файл");
            this.toolTip.SetToolTip(LoadFileButton, "Загрузить данные для пересчета из файла");
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            List<string[]> values;
            try
            {
                values=checkValues(listXInput,listYInput);
            }
            catch (Exception exception)
            {
                this.ImaginaryMessage.ShowMessage(exception.Message);
                return;
            }
            SaveFileDialog dlg= this.SaveDataDlg;
            dlg.Filter = "Txt|*.txt|Excel|*.xlsx";
            dlg.FilterIndex = 1;
            var status = dlg.ShowDialog();
            if (status == DialogResult.OK && (dlg.FileName!="" || dlg.FileName!=null))
            {
                FileHelper fileHelper = new FileHelper();
                fileHelper.WriteToFile(dlg.FilterIndex, dlg.FileName, values.Select(x=>x[0]).ToArray(), values.Select(x=>x[1]).ToArray());
            }
            this.statusToolTip.Show("Сохранено",this,16,39,1200);
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = this.loadInputFileDlg;
            dlg.Filter = "Txt|*.txt|Excel|*.xlsx";
            dlg.FilterIndex = 1;
            var status=dlg.ShowDialog();
            if (status == DialogResult.OK)
            {
                FileHelper fileHelper = new FileHelper();
                List<string[]> points;
                try
                {
                     points= fileHelper.LoadFromFile(dlg.FilterIndex, dlg.FileName);
                }
                catch (IOException exception)
                {
                    this.ImaginaryMessage.ShowMessage("Необходимо закрыть загружаемый файл");
                    return;
                }
                DropTables();
                for (int i = 0; i < points.Count; i++)
                {
                    AddNewXYFields(i + 1);
                    listXInput.ElementAt(i).Text = points.ElementAt(i)[0];
                    listYInput.ElementAt(i).Text = points.ElementAt(i)[1];
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            List<string[]> listCoord = new List<string[]>();
            string system=this.InputSystem.Text;
            if (system.Equals("Выберите систему"))
            {
                this.ImaginaryMessage.ShowMessage("Выберите систему");
                return;
            }
            try
            {
                listCoord = checkValues(listXInput, listYInput);
            }
            catch (Exception exception)
            {
                this.ImaginaryMessage.ShowMessage(exception.Message);
                return;
            }
            listCoord = coordHelper.transformCoords(system, listCoord, "transform");
            listXResult.ForEach(x => x.Text = "");
            listYResult.ForEach(x => x.Text = "");
            for (int i = 0; i < listCoord.Count; i++)
            {
                listXResult.ElementAt(i).Text = listCoord.ElementAt(i)[0];
                listYResult.ElementAt(i).Text = listCoord.ElementAt(i)[1];
            }
        }

        private void SaveResultBtn_Click(object sender, EventArgs e)
        {
            List<string[]> values;
            try
            {
                values=checkValues(listXResult, listYResult);
            }
            catch (Exception exception)
            {
                this.ImaginaryMessage.ShowMessage(exception.Message);
                return;
            }
            SaveFileDialog dlg = this.SaveDataDlg;
            dlg.Filter = "Txt|*.txt|Excel|*.xlsx|GPX|*.gpx";
            dlg.FilterIndex = 3;
            var status = dlg.ShowDialog();
            if (status == DialogResult.OK && (dlg.FileName != "" || dlg.FileName != null))
            {
                FileHelper fileHelper = new FileHelper();
                fileHelper.WriteToFile(dlg.FilterIndex, dlg.FileName, values.Select(x => x[1]).ToArray(), values.Select(x => x[0]).ToArray());
            }
            this.statusToolTip.Show("Сохранено", this, 16, 39, 1200);
        }

        private void LoadResultBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = this.loadInputFileDlg;
            dlg.Filter = "Txt|*.txt|Excel|*.xlsx|GPX|*.gpx";
            dlg.FilterIndex = 3;
            var status = dlg.ShowDialog();
            if (status == DialogResult.OK)
            {
                FileHelper fileHelper = new FileHelper();
                List<string[]> points;
                try
                {
                    points = fileHelper.LoadFromFile(dlg.FilterIndex, dlg.FileName);
                }
                catch (IOException exception)
                {
                    this.ImaginaryMessage.ShowMessage("Необходимо закрыть загружаемый файл");
                    return;
                }
                DropTables();
                for (int i = 0; i < points.Count; i++)
                {
                    AddNewXYFields(i + 1);
                    listXResult.ElementAt(i).Text = points.ElementAt(i)[1];
                    listYResult.ElementAt(i).Text = points.ElementAt(i)[0];
                }
            }
        }

        private void ReverseRunBtn_Click(object sender, EventArgs e)
        {
            List<string[]> listCoord = new List<string[]>();
            string system = this.InputSystem.Text;
            if (system.Equals("Выберите систему"))
            {
                this.ImaginaryMessage.ShowMessage("Выберите систему");
                return;
            }
            try
            {
                listCoord = checkValues(listXResult, listYResult);
            }
            catch (Exception exception)
            {
                this.ImaginaryMessage.ShowMessage(exception.Message);
                return;
            }
            listCoord = coordHelper.transformCoords(system, listCoord, "reverse");
            listXInput.ForEach(x => x.Text = "");
            listYInput.ForEach(x => x.Text = "");
            for (int i = 0; i < listCoord.Count; i++)
            {
                listXInput.ElementAt(i).Text = listCoord.ElementAt(i)[0];
                listYInput.ElementAt(i).Text = listCoord.ElementAt(i)[1];
            }
        }

        private List<string[]> checkValues(List<TextBox> xValues, List<TextBox> yValues) {
            string[] Xs=xValues.Select(x=>x.Text).ToArray();
            string[] Ys=yValues.Select(x=>x.Text).ToArray();
            List<string[]> validateValues = new List<string[]>();
            int count=Xs.Where(x=>x.Length>0).ToArray().Length+Ys.Where(x=>x.Length>0).ToArray().Length;
            if (count>1){
                for (int i = 0; i < xValues.Count; i++)
                {
                    string x = Xs[i];
                    string y =Ys[i];
                    if (x.Length > 0 && y.Length > 0)
                    {
                        Regex regExp = new Regex("^-?[0-9]+\\,?[0-9]{0,10}$");
                        if (regExp.IsMatch(x) && regExp.IsMatch(y))
                        {
                            validateValues.Add(new string[] { x, y });
                        }
                        else
                        {
                            throw new Exception("Ошибка при вводе");
                        }
                    }
                    else
                    {
                        if (i != Xs.Length-1)
                        {
                            if (Xs[i + 1].Length != 0 && Ys[i + 1].Length != 0)
                            {
                                throw new Exception("Введите недостающее значение");
                            }
                        }
                        
                    }
                }
            } else {
                throw new Exception("Введите значения");
            }
            return validateValues;
        }
    }
}