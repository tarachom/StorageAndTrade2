﻿
namespace StorageAndTrade
{
    partial class Form_ПереміщенняТоварівДокумент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ПереміщенняТоварівДокумент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox_НомерДок = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_ДатаДок = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_ЧасДок = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Коментар = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_ГосподарськаОперація = new System.Windows.Forms.ComboBox();
            this.directoryControl_СкладОтримувач = new StorageAndTrade.DirectoryControl();
            this.label6 = new System.Windows.Forms.Label();
            this.directoryControl_СкладВідправник = new StorageAndTrade.DirectoryControl();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryControl_Організація = new StorageAndTrade.DirectoryControl();
            this.label12 = new System.Windows.Forms.Label();
            this.directoryControl_Підрозділ = new StorageAndTrade.DirectoryControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари = new StorageAndTrade.Form_ПереміщенняТоварів_ТабличнаЧастина_Товари();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSaveAndSpend = new System.Windows.Forms.Button();
            this.buttonSpend = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_FindToJournal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonДрукПроводок = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(550, 3);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(191, 31);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(251, 3);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox_НомерДок
            // 
            this.textBox_НомерДок.BackColor = System.Drawing.Color.White;
            this.textBox_НомерДок.Location = new System.Drawing.Point(279, 12);
            this.textBox_НомерДок.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_НомерДок.Name = "textBox_НомерДок";
            this.textBox_НомерДок.ReadOnly = true;
            this.textBox_НомерДок.Size = new System.Drawing.Size(153, 23);
            this.textBox_НомерДок.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Номер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дата:";
            // 
            // dateTimePicker_ДатаДок
            // 
            this.dateTimePicker_ДатаДок.Location = new System.Drawing.Point(474, 12);
            this.dateTimePicker_ДатаДок.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_ДатаДок.Name = "dateTimePicker_ДатаДок";
            this.dateTimePicker_ДатаДок.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker_ДатаДок.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker_ЧасДок);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox_Коментар);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox_ГосподарськаОперація);
            this.panel1.Controls.Add(this.directoryControl_СкладОтримувач);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.directoryControl_СкладВідправник);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.directoryControl_Організація);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker_ДатаДок);
            this.panel1.Controls.Add(this.textBox_НомерДок);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 145);
            this.panel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Переміщення товарів";
            // 
            // dateTimePicker_ЧасДок
            // 
            this.dateTimePicker_ЧасДок.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_ЧасДок.Location = new System.Drawing.Point(710, 12);
            this.dateTimePicker_ЧасДок.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_ЧасДок.Name = "dateTimePicker_ЧасДок";
            this.dateTimePicker_ЧасДок.ShowUpDown = true;
            this.dateTimePicker_ЧасДок.Size = new System.Drawing.Size(88, 23);
            this.dateTimePicker_ЧасДок.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 69;
            this.label13.Text = "Коментар:";
            // 
            // textBox_Коментар
            // 
            this.textBox_Коментар.Location = new System.Drawing.Point(88, 111);
            this.textBox_Коментар.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Коментар.Name = "textBox_Коментар";
            this.textBox_Коментар.Size = new System.Drawing.Size(960, 23);
            this.textBox_Коментар.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Операція:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 83);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 60;
            this.label11.Text = "-->  Склад:";
            // 
            // comboBox_ГосподарськаОперація
            // 
            this.comboBox_ГосподарськаОперація.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ГосподарськаОперація.FormattingEnabled = true;
            this.comboBox_ГосподарськаОперація.Location = new System.Drawing.Point(609, 47);
            this.comboBox_ГосподарськаОперація.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ГосподарськаОперація.Name = "comboBox_ГосподарськаОперація";
            this.comboBox_ГосподарськаОперація.Size = new System.Drawing.Size(438, 23);
            this.comboBox_ГосподарськаОперація.TabIndex = 58;
            // 
            // directoryControl_СкладОтримувач
            // 
            this.directoryControl_СкладОтримувач.AfterSelectFunc = null;
            this.directoryControl_СкладОтримувач.BeforeClickOpenFunc = null;
            this.directoryControl_СкладОтримувач.BeforeFindFunc = null;
            this.directoryControl_СкладОтримувач.Bind = null;
            this.directoryControl_СкладОтримувач.DirectoryPointerItem = null;
            this.directoryControl_СкладОтримувач.Location = new System.Drawing.Point(609, 75);
            this.directoryControl_СкладОтримувач.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_СкладОтримувач.Name = "directoryControl_СкладОтримувач";
            this.directoryControl_СкладОтримувач.QueryFind = null;
            this.directoryControl_СкладОтримувач.SelectForm = null;
            this.directoryControl_СкладОтримувач.Size = new System.Drawing.Size(439, 31);
            this.directoryControl_СкладОтримувач.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Склад:";
            // 
            // directoryControl_СкладВідправник
            // 
            this.directoryControl_СкладВідправник.AfterSelectFunc = null;
            this.directoryControl_СкладВідправник.BeforeClickOpenFunc = null;
            this.directoryControl_СкладВідправник.BeforeFindFunc = null;
            this.directoryControl_СкладВідправник.Bind = null;
            this.directoryControl_СкладВідправник.DirectoryPointerItem = null;
            this.directoryControl_СкладВідправник.Location = new System.Drawing.Point(88, 75);
            this.directoryControl_СкладВідправник.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_СкладВідправник.Name = "directoryControl_СкладВідправник";
            this.directoryControl_СкладВідправник.QueryFind = null;
            this.directoryControl_СкладВідправник.SelectForm = null;
            this.directoryControl_СкладВідправник.Size = new System.Drawing.Size(439, 31);
            this.directoryControl_СкладВідправник.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Організація:";
            // 
            // directoryControl_Організація
            // 
            this.directoryControl_Організація.AfterSelectFunc = null;
            this.directoryControl_Організація.BeforeClickOpenFunc = null;
            this.directoryControl_Організація.BeforeFindFunc = null;
            this.directoryControl_Організація.Bind = null;
            this.directoryControl_Організація.DirectoryPointerItem = null;
            this.directoryControl_Організація.Location = new System.Drawing.Point(88, 42);
            this.directoryControl_Організація.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Організація.Name = "directoryControl_Організація";
            this.directoryControl_Організація.QueryFind = null;
            this.directoryControl_Організація.SelectForm = null;
            this.directoryControl_Організація.Size = new System.Drawing.Size(438, 31);
            this.directoryControl_Організація.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 62;
            this.label12.Text = "Підрозділ:";
            // 
            // directoryControl_Підрозділ
            // 
            this.directoryControl_Підрозділ.AfterSelectFunc = null;
            this.directoryControl_Підрозділ.BeforeClickOpenFunc = null;
            this.directoryControl_Підрозділ.BeforeFindFunc = null;
            this.directoryControl_Підрозділ.Bind = null;
            this.directoryControl_Підрозділ.DirectoryPointerItem = null;
            this.directoryControl_Підрозділ.Location = new System.Drawing.Point(84, 16);
            this.directoryControl_Підрозділ.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Підрозділ.Name = "directoryControl_Підрозділ";
            this.directoryControl_Підрозділ.QueryFind = null;
            this.directoryControl_Підрозділ.SelectForm = null;
            this.directoryControl_Підрозділ.Size = new System.Drawing.Size(465, 31);
            this.directoryControl_Підрозділ.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(4, 183);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 378);
            this.panel2.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 378);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ПереміщенняТоварів_ТабличнаЧастина_Товари);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товари";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ПереміщенняТоварів_ТабличнаЧастина_Товари
            // 
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.Location = new System.Drawing.Point(4, 3);
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.Name = "ПереміщенняТоварів_ТабличнаЧастина_Товари";
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.Size = new System.Drawing.Size(1052, 344);
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.TabIndex = 0;
            this.ПереміщенняТоварів_ТабличнаЧастина_Товари.ДокументОбєкт = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.directoryControl_Підрозділ);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додаток";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.buttonSaveAndSpend);
            this.panel3.Controls.Add(this.buttonSpend);
            this.panel3.Controls.Add(this.buttonClose);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(4, 565);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 38);
            this.panel3.TabIndex = 25;
            // 
            // buttonSaveAndSpend
            // 
            this.buttonSaveAndSpend.Location = new System.Drawing.Point(4, 3);
            this.buttonSaveAndSpend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveAndSpend.Name = "buttonSaveAndSpend";
            this.buttonSaveAndSpend.Size = new System.Drawing.Size(155, 31);
            this.buttonSaveAndSpend.TabIndex = 18;
            this.buttonSaveAndSpend.Text = "Зберегти і провести";
            this.buttonSaveAndSpend.UseVisualStyleBackColor = true;
            this.buttonSaveAndSpend.Click += new System.EventHandler(this.buttonSaveAndSpend_Click);
            // 
            // buttonSpend
            // 
            this.buttonSpend.Location = new System.Drawing.Point(364, 3);
            this.buttonSpend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSpend.Name = "buttonSpend";
            this.buttonSpend.Size = new System.Drawing.Size(106, 31);
            this.buttonSpend.TabIndex = 17;
            this.buttonSpend.Text = "Провести";
            this.buttonSpend.UseVisualStyleBackColor = true;
            this.buttonSpend.Click += new System.EventHandler(this.buttonSpend_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_FindToJournal,
            this.toolStripButtonДрукПроводок});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_FindToJournal
            // 
            this.toolStripButton_FindToJournal.Image = global::StorageAndTrade.Properties.Resources.up;
            this.toolStripButton_FindToJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_FindToJournal.Name = "toolStripButton_FindToJournal";
            this.toolStripButton_FindToJournal.Size = new System.Drawing.Size(123, 22);
            this.toolStripButton_FindToJournal.Text = "Знайти в журналі";
            this.toolStripButton_FindToJournal.Click += new System.EventHandler(this.toolStripButton_FindToJournal_Click);
            // 
            // toolStripButtonДрукПроводок
            // 
            this.toolStripButtonДрукПроводок.Image = global::StorageAndTrade.Properties.Resources.page_2;
            this.toolStripButtonДрукПроводок.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonДрукПроводок.Name = "toolStripButtonДрукПроводок";
            this.toolStripButtonДрукПроводок.Size = new System.Drawing.Size(82, 22);
            this.toolStripButtonДрукПроводок.Text = "Проводки";
            this.toolStripButtonДрукПроводок.Click += new System.EventHandler(this.toolStripButtonДрукПроводок_Click);
            // 
            // Form_ПереміщенняТоварівДокумент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 609);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ПереміщенняТоварівДокумент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переміщення товарів";
            this.Load += new System.EventHandler(this.Form_ПереміщенняТоварівДокумент_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox_НомерДок;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ДатаДок;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_Організація;
        private System.Windows.Forms.Label label6;
        private DirectoryControl directoryControl_СкладВідправник;
        private System.Windows.Forms.ComboBox comboBox_ГосподарськаОперація;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DirectoryControl directoryControl_СкладОтримувач;
        private System.Windows.Forms.Label label12;
        private DirectoryControl directoryControl_Підрозділ;
        private StorageAndTrade.Form_ПереміщенняТоварів_ТабличнаЧастина_Товари ПереміщенняТоварів_ТабличнаЧастина_Товари;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSpend;
        private System.Windows.Forms.Button buttonSaveAndSpend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Коментар;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ЧасДок;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_FindToJournal;
        private System.Windows.Forms.ToolStripButton toolStripButtonДрукПроводок;
    }
}