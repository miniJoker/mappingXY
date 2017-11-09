namespace MappingXY
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputPanel = new System.Windows.Forms.Panel();
            this.RunButton = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.InputCoordinateBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CleanFormButton = new System.Windows.Forms.Button();
            this.InputTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddFieldButton = new System.Windows.Forms.Button();
            this.InputSystemBox = new System.Windows.Forms.GroupBox();
            this.ImaginaryMessage = new MappingXY.DefaultItems.ImaginaryMessage();
            this.InputComboBoxLabel = new System.Windows.Forms.Label();
            this.InputSystem = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveDataDlg = new System.Windows.Forms.SaveFileDialog();
            this.statusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loadInputFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.ReverseRunBtn = new System.Windows.Forms.Button();
            this.SaveResultBtn = new System.Windows.Forms.Button();
            this.LoadResultBtn = new System.Windows.Forms.Button();
            this.OutputCoordinateBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OutputSystemBox = new System.Windows.Forms.GroupBox();
            this.OutputComboBoxLabel = new System.Windows.Forms.Label();
            this.OutputSystem = new System.Windows.Forms.ComboBox();
            this.InputPanel.SuspendLayout();
            this.InputCoordinateBox.SuspendLayout();
            this.InputSystemBox.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.OutputCoordinateBox.SuspendLayout();
            this.OutputSystemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.AutoSize = true;
            this.InputPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.RunButton);
            this.InputPanel.Controls.Add(this.SaveDataButton);
            this.InputPanel.Controls.Add(this.LoadFileButton);
            this.InputPanel.Controls.Add(this.InputCoordinateBox);
            this.InputPanel.Controls.Add(this.InputSystemBox);
            this.InputPanel.Location = new System.Drawing.Point(8, 8);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Padding = new System.Windows.Forms.Padding(10);
            this.InputPanel.Size = new System.Drawing.Size(455, 545);
            this.InputPanel.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.Snow;
            this.RunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RunButton.Image = ((System.Drawing.Image)(resources.GetObject("RunButton.Image")));
            this.RunButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunButton.Location = new System.Drawing.Point(265, 490);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(175, 40);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Пересчитать координаты";
            this.RunButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.BackColor = System.Drawing.Color.Snow;
            this.SaveDataButton.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.SaveDataButton.FlatAppearance.BorderSize = 0;
            this.SaveDataButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveDataButton.Image")));
            this.SaveDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveDataButton.Location = new System.Drawing.Point(13, 490);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(141, 40);
            this.SaveDataButton.TabIndex = 4;
            this.SaveDataButton.Text = "Сохранить данные";
            this.SaveDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.BackColor = System.Drawing.Color.Snow;
            this.LoadFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LoadFileButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadFileButton.Image")));
            this.LoadFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadFileButton.Location = new System.Drawing.Point(160, 490);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(99, 40);
            this.LoadFileButton.TabIndex = 3;
            this.LoadFileButton.Text = "Загрузить";
            this.LoadFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadFileButton.UseVisualStyleBackColor = false;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // InputCoordinateBox
            // 
            this.InputCoordinateBox.BackColor = System.Drawing.Color.Snow;
            this.InputCoordinateBox.Controls.Add(this.label2);
            this.InputCoordinateBox.Controls.Add(this.label1);
            this.InputCoordinateBox.Controls.Add(this.CleanFormButton);
            this.InputCoordinateBox.Controls.Add(this.InputTableLayout);
            this.InputCoordinateBox.Controls.Add(this.AddFieldButton);
            this.InputCoordinateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputCoordinateBox.Location = new System.Drawing.Point(13, 77);
            this.InputCoordinateBox.Name = "InputCoordinateBox";
            this.InputCoordinateBox.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.InputCoordinateBox.Size = new System.Drawing.Size(427, 407);
            this.InputCoordinateBox.TabIndex = 1;
            this.InputCoordinateBox.TabStop = false;
            this.InputCoordinateBox.Text = "Координаты в исходной системе ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // CleanFormButton
            // 
            this.CleanFormButton.BackColor = System.Drawing.Color.Snow;
            this.CleanFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CleanFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CleanFormButton.Image = ((System.Drawing.Image)(resources.GetObject("CleanFormButton.Image")));
            this.CleanFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CleanFormButton.Location = new System.Drawing.Point(147, 359);
            this.CleanFormButton.Name = "CleanFormButton";
            this.CleanFormButton.Size = new System.Drawing.Size(99, 40);
            this.CleanFormButton.TabIndex = 5;
            this.CleanFormButton.Text = "Очистить";
            this.CleanFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CleanFormButton.UseVisualStyleBackColor = false;
            this.CleanFormButton.Click += new System.EventHandler(this.CleanFormButton_Click);
            // 
            // InputTableLayout
            // 
            this.InputTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTableLayout.AutoScroll = true;
            this.InputTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InputTableLayout.ColumnCount = 3;
            this.InputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.InputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5F));
            this.InputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5F));
            this.InputTableLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.InputTableLayout.Location = new System.Drawing.Point(25, 58);
            this.InputTableLayout.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.InputTableLayout.Name = "InputTableLayout";
            this.InputTableLayout.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.InputTableLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputTableLayout.RowCount = 2;
            this.InputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.InputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.InputTableLayout.Size = new System.Drawing.Size(377, 295);
            this.InputTableLayout.TabIndex = 0;
            // 
            // AddFieldButton
            // 
            this.AddFieldButton.BackColor = System.Drawing.Color.Snow;
            this.AddFieldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddFieldButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFieldButton.Image")));
            this.AddFieldButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddFieldButton.Location = new System.Drawing.Point(7, 359);
            this.AddFieldButton.Name = "AddFieldButton";
            this.AddFieldButton.Size = new System.Drawing.Size(134, 40);
            this.AddFieldButton.TabIndex = 2;
            this.AddFieldButton.Text = "Добавить поля";
            this.AddFieldButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddFieldButton.UseVisualStyleBackColor = false;
            this.AddFieldButton.Click += new System.EventHandler(this.AddFieldButton_Click);
            // 
            // InputSystemBox
            // 
            this.InputSystemBox.BackColor = System.Drawing.Color.Snow;
            this.InputSystemBox.Controls.Add(this.ImaginaryMessage);
            this.InputSystemBox.Controls.Add(this.InputComboBoxLabel);
            this.InputSystemBox.Controls.Add(this.InputSystem);
            this.InputSystemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSystemBox.Location = new System.Drawing.Point(13, 13);
            this.InputSystemBox.Name = "InputSystemBox";
            this.InputSystemBox.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.InputSystemBox.Size = new System.Drawing.Size(427, 58);
            this.InputSystemBox.TabIndex = 0;
            this.InputSystemBox.TabStop = false;
            this.InputSystemBox.Text = "Исходная проекция";
            // 
            // ImaginaryMessage
            // 
            this.ImaginaryMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ImaginaryMessage.FlatAppearance.BorderSize = 0;
            this.ImaginaryMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImaginaryMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImaginaryMessage.Location = new System.Drawing.Point(7, -3);
            this.ImaginaryMessage.Name = "ImaginaryMessage";
            this.ImaginaryMessage.Size = new System.Drawing.Size(178, 45);
            this.ImaginaryMessage.TabIndex = 0;
            this.ImaginaryMessage.UseVisualStyleBackColor = true;
            this.ImaginaryMessage.Visible = false;
            // 
            // InputComboBoxLabel
            // 
            this.InputComboBoxLabel.AutoSize = true;
            this.InputComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputComboBoxLabel.Location = new System.Drawing.Point(23, 24);
            this.InputComboBoxLabel.Name = "InputComboBoxLabel";
            this.InputComboBoxLabel.Size = new System.Drawing.Size(110, 13);
            this.InputComboBoxLabel.TabIndex = 1;
            this.InputComboBoxLabel.Text = "Система координат:";
            // 
            // InputSystem
            // 
            this.InputSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.InputSystem.FormattingEnabled = true;
            this.InputSystem.Location = new System.Drawing.Point(166, 21);
            this.InputSystem.Name = "InputSystem";
            this.InputSystem.Size = new System.Drawing.Size(219, 21);
            this.InputSystem.TabIndex = 0;
            this.InputSystem.Text = "Выберите систему";
            // 
            // statusToolTip
            // 
            this.statusToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // loadInputFileDlg
            // 
            this.loadInputFileDlg.FileName = "openFileDialog1";
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoSize = true;
            this.OutputPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPanel.Controls.Add(this.ReverseRunBtn);
            this.OutputPanel.Controls.Add(this.SaveResultBtn);
            this.OutputPanel.Controls.Add(this.LoadResultBtn);
            this.OutputPanel.Controls.Add(this.OutputCoordinateBox);
            this.OutputPanel.Controls.Add(this.OutputSystemBox);
            this.OutputPanel.Location = new System.Drawing.Point(469, 8);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Padding = new System.Windows.Forms.Padding(10);
            this.OutputPanel.Size = new System.Drawing.Size(455, 545);
            this.OutputPanel.TabIndex = 7;
            // 
            // ReverseRunBtn
            // 
            this.ReverseRunBtn.BackColor = System.Drawing.Color.Snow;
            this.ReverseRunBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReverseRunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ReverseRunBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReverseRunBtn.Image")));
            this.ReverseRunBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReverseRunBtn.Location = new System.Drawing.Point(13, 490);
            this.ReverseRunBtn.Name = "ReverseRunBtn";
            this.ReverseRunBtn.Size = new System.Drawing.Size(155, 40);
            this.ReverseRunBtn.TabIndex = 7;
            this.ReverseRunBtn.Text = "Пересчитать обратно";
            this.ReverseRunBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReverseRunBtn.UseVisualStyleBackColor = false;
            this.ReverseRunBtn.Click += new System.EventHandler(this.ReverseRunBtn_Click);
            // 
            // SaveResultBtn
            // 
            this.SaveResultBtn.BackColor = System.Drawing.Color.Snow;
            this.SaveResultBtn.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.SaveResultBtn.FlatAppearance.BorderSize = 0;
            this.SaveResultBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveResultBtn.Image")));
            this.SaveResultBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveResultBtn.Location = new System.Drawing.Point(174, 490);
            this.SaveResultBtn.Name = "SaveResultBtn";
            this.SaveResultBtn.Size = new System.Drawing.Size(161, 40);
            this.SaveResultBtn.TabIndex = 4;
            this.SaveResultBtn.Text = "Сохранить результат";
            this.SaveResultBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveResultBtn.UseVisualStyleBackColor = false;
            this.SaveResultBtn.Click += new System.EventHandler(this.SaveResultBtn_Click);
            // 
            // LoadResultBtn
            // 
            this.LoadResultBtn.BackColor = System.Drawing.Color.Snow;
            this.LoadResultBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LoadResultBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoadResultBtn.Image")));
            this.LoadResultBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadResultBtn.Location = new System.Drawing.Point(341, 490);
            this.LoadResultBtn.Name = "LoadResultBtn";
            this.LoadResultBtn.Size = new System.Drawing.Size(99, 40);
            this.LoadResultBtn.TabIndex = 3;
            this.LoadResultBtn.Text = "Загрузить";
            this.LoadResultBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadResultBtn.UseVisualStyleBackColor = false;
            this.LoadResultBtn.Click += new System.EventHandler(this.LoadResultBtn_Click);
            // 
            // OutputCoordinateBox
            // 
            this.OutputCoordinateBox.BackColor = System.Drawing.Color.Snow;
            this.OutputCoordinateBox.Controls.Add(this.label3);
            this.OutputCoordinateBox.Controls.Add(this.label4);
            this.OutputCoordinateBox.Controls.Add(this.OutputTableLayout);
            this.OutputCoordinateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputCoordinateBox.Location = new System.Drawing.Point(13, 77);
            this.OutputCoordinateBox.Name = "OutputCoordinateBox";
            this.OutputCoordinateBox.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.OutputCoordinateBox.Size = new System.Drawing.Size(427, 407);
            this.OutputCoordinateBox.TabIndex = 1;
            this.OutputCoordinateBox.TabStop = false;
            this.OutputCoordinateBox.Text = "Координаты в новой системе ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Широта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Долгота";
            // 
            // OutputTableLayout
            // 
            this.OutputTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTableLayout.AutoScroll = true;
            this.OutputTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutputTableLayout.ColumnCount = 3;
            this.OutputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.OutputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5F));
            this.OutputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5F));
            this.OutputTableLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OutputTableLayout.Location = new System.Drawing.Point(26, 58);
            this.OutputTableLayout.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.OutputTableLayout.Name = "OutputTableLayout";
            this.OutputTableLayout.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.OutputTableLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputTableLayout.RowCount = 2;
            this.OutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.OutputTableLayout.Size = new System.Drawing.Size(377, 295);
            this.OutputTableLayout.TabIndex = 0;
            // 
            // OutputSystemBox
            // 
            this.OutputSystemBox.BackColor = System.Drawing.Color.Snow;
            this.OutputSystemBox.Controls.Add(this.OutputComboBoxLabel);
            this.OutputSystemBox.Controls.Add(this.OutputSystem);
            this.OutputSystemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputSystemBox.Location = new System.Drawing.Point(13, 13);
            this.OutputSystemBox.Name = "OutputSystemBox";
            this.OutputSystemBox.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.OutputSystemBox.Size = new System.Drawing.Size(427, 58);
            this.OutputSystemBox.TabIndex = 0;
            this.OutputSystemBox.TabStop = false;
            this.OutputSystemBox.Text = "Новая проекция";
            // 
            // OutputComboBoxLabel
            // 
            this.OutputComboBoxLabel.AutoSize = true;
            this.OutputComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputComboBoxLabel.Location = new System.Drawing.Point(23, 24);
            this.OutputComboBoxLabel.Name = "OutputComboBoxLabel";
            this.OutputComboBoxLabel.Size = new System.Drawing.Size(110, 13);
            this.OutputComboBoxLabel.TabIndex = 1;
            this.OutputComboBoxLabel.Text = "Система координат:";
            // 
            // OutputSystem
            // 
            this.OutputSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OutputSystem.FormattingEnabled = true;
            this.OutputSystem.Items.AddRange(new object[] {
            "WGS84"});
            this.OutputSystem.Location = new System.Drawing.Point(166, 21);
            this.OutputSystem.Name = "OutputSystem";
            this.OutputSystem.Size = new System.Drawing.Size(219, 21);
            this.OutputSystem.TabIndex = 0;
            this.OutputSystem.Text = "WGS84";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.InputPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Text = "Преобразование координат";
            this.InputPanel.ResumeLayout(false);
            this.InputCoordinateBox.ResumeLayout(false);
            this.InputCoordinateBox.PerformLayout();
            this.InputSystemBox.ResumeLayout(false);
            this.InputSystemBox.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputCoordinateBox.ResumeLayout(false);
            this.OutputCoordinateBox.PerformLayout();
            this.OutputSystemBox.ResumeLayout(false);
            this.OutputSystemBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.GroupBox InputSystemBox;
        private System.Windows.Forms.ComboBox InputSystem;
        private System.Windows.Forms.GroupBox InputCoordinateBox;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button AddFieldButton;
        private System.Windows.Forms.Label InputComboBoxLabel;
        private System.Windows.Forms.Button CleanFormButton;
        private System.Windows.Forms.TableLayoutPanel InputTableLayout;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog SaveDataDlg;
        private System.Windows.Forms.ToolTip statusToolTip;
        private System.Windows.Forms.OpenFileDialog loadInputFileDlg;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Button SaveResultBtn;
        private System.Windows.Forms.Button LoadResultBtn;
        private System.Windows.Forms.GroupBox OutputCoordinateBox;
        private System.Windows.Forms.TableLayoutPanel OutputTableLayout;
        private System.Windows.Forms.GroupBox OutputSystemBox;
        private System.Windows.Forms.Label OutputComboBoxLabel;
        private System.Windows.Forms.ComboBox OutputSystem;
        private System.Windows.Forms.Button ReverseRunBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DefaultItems.ImaginaryMessage ImaginaryMessage;

    }
}

