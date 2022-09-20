
namespace StorageAndTrade
{
    partial class Form_ТовариНаСкладах_Звіт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ТовариНаСкладах_Звіт));
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOstatok = new System.Windows.Forms.Button();
            this.directoryControl_ХарактеристикаНоменклатури = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Склади = new StorageAndTrade.DirectoryControl();
            this.directoryControl_СкладиПапки = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Номенклатура = new StorageAndTrade.DirectoryControl();
            this.directoryControl_НоменклатураПапка = new StorageAndTrade.DirectoryControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOstatokAndOborot = new System.Windows.Forms.Button();
            this.button_Documents = new System.Windows.Forms.Button();
            this.directoryControl_Серія = new StorageAndTrade.DirectoryControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(288, 12);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(227, 23);
            this.dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Період з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.Location = new System.Drawing.Point(551, 12);
            this.dateTimeStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(227, 23);
            this.dateTimeStop.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Папка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Номенклатура:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Папка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Склад:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "Характеристика:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(927, 183);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 31);
            this.buttonClose.TabIndex = 72;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOstatok
            // 
            this.buttonOstatok.Location = new System.Drawing.Point(9, 183);
            this.buttonOstatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOstatok.Name = "buttonOstatok";
            this.buttonOstatok.Size = new System.Drawing.Size(105, 31);
            this.buttonOstatok.TabIndex = 73;
            this.buttonOstatok.Text = "Залишки";
            this.buttonOstatok.UseVisualStyleBackColor = true;
            this.buttonOstatok.Click += new System.EventHandler(this.buttonOstatok_Click);
            // 
            // directoryControl_ХарактеристикаНоменклатури
            // 
            this.directoryControl_ХарактеристикаНоменклатури.AfterSelectFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.BeforeClickOpenFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.BeforeFindFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.Bind = null;
            this.directoryControl_ХарактеристикаНоменклатури.DirectoryPointerItem = null;
            this.directoryControl_ХарактеристикаНоменклатури.Location = new System.Drawing.Point(115, 86);
            this.directoryControl_ХарактеристикаНоменклатури.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_ХарактеристикаНоменклатури.Name = "directoryControl_ХарактеристикаНоменклатури";
            this.directoryControl_ХарактеристикаНоменклатури.QueryFind = null;
            this.directoryControl_ХарактеристикаНоменклатури.SelectForm = null;
            this.directoryControl_ХарактеристикаНоменклатури.Size = new System.Drawing.Size(416, 27);
            this.directoryControl_ХарактеристикаНоменклатури.TabIndex = 63;
            // 
            // directoryControl_Склади
            // 
            this.directoryControl_Склади.AfterSelectFunc = null;
            this.directoryControl_Склади.BeforeClickOpenFunc = null;
            this.directoryControl_Склади.BeforeFindFunc = null;
            this.directoryControl_Склади.Bind = null;
            this.directoryControl_Склади.DirectoryPointerItem = null;
            this.directoryControl_Склади.Location = new System.Drawing.Point(70, 54);
            this.directoryControl_Склади.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Склади.Name = "directoryControl_Склади";
            this.directoryControl_Склади.QueryFind = null;
            this.directoryControl_Склади.SelectForm = null;
            this.directoryControl_Склади.Size = new System.Drawing.Size(385, 27);
            this.directoryControl_Склади.TabIndex = 61;
            // 
            // directoryControl_СкладиПапки
            // 
            this.directoryControl_СкладиПапки.AfterSelectFunc = null;
            this.directoryControl_СкладиПапки.BeforeClickOpenFunc = null;
            this.directoryControl_СкладиПапки.BeforeFindFunc = null;
            this.directoryControl_СкладиПапки.Bind = null;
            this.directoryControl_СкладиПапки.DirectoryPointerItem = null;
            this.directoryControl_СкладиПапки.Location = new System.Drawing.Point(70, 22);
            this.directoryControl_СкладиПапки.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_СкладиПапки.Name = "directoryControl_СкладиПапки";
            this.directoryControl_СкладиПапки.QueryFind = null;
            this.directoryControl_СкладиПапки.SelectForm = null;
            this.directoryControl_СкладиПапки.Size = new System.Drawing.Size(385, 27);
            this.directoryControl_СкладиПапки.TabIndex = 59;
            // 
            // directoryControl_Номенклатура
            // 
            this.directoryControl_Номенклатура.AfterSelectFunc = null;
            this.directoryControl_Номенклатура.BeforeClickOpenFunc = null;
            this.directoryControl_Номенклатура.BeforeFindFunc = null;
            this.directoryControl_Номенклатура.Bind = null;
            this.directoryControl_Номенклатура.DirectoryPointerItem = null;
            this.directoryControl_Номенклатура.Location = new System.Drawing.Point(115, 54);
            this.directoryControl_Номенклатура.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Номенклатура.Name = "directoryControl_Номенклатура";
            this.directoryControl_Номенклатура.QueryFind = null;
            this.directoryControl_Номенклатура.SelectForm = null;
            this.directoryControl_Номенклатура.Size = new System.Drawing.Size(416, 27);
            this.directoryControl_Номенклатура.TabIndex = 57;
            // 
            // directoryControl_НоменклатураПапка
            // 
            this.directoryControl_НоменклатураПапка.AfterSelectFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeClickOpenFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeFindFunc = null;
            this.directoryControl_НоменклатураПапка.Bind = null;
            this.directoryControl_НоменклатураПапка.DirectoryPointerItem = null;
            this.directoryControl_НоменклатураПапка.Location = new System.Drawing.Point(115, 22);
            this.directoryControl_НоменклатураПапка.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_НоменклатураПапка.Name = "directoryControl_НоменклатураПапка";
            this.directoryControl_НоменклатураПапка.QueryFind = null;
            this.directoryControl_НоменклатураПапка.SelectForm = null;
            this.directoryControl_НоменклатураПапка.Size = new System.Drawing.Size(416, 27);
            this.directoryControl_НоменклатураПапка.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.directoryControl_НоменклатураПапка);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.directoryControl_Номенклатура);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.directoryControl_ХарактеристикаНоменклатури);
            this.groupBox1.Location = new System.Drawing.Point(10, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(543, 123);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номенклатура";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.directoryControl_Склади);
            this.groupBox2.Controls.Add(this.directoryControl_СкладиПапки);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(561, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(471, 90);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Склад";
            // 
            // buttonOstatokAndOborot
            // 
            this.buttonOstatokAndOborot.Location = new System.Drawing.Point(121, 183);
            this.buttonOstatokAndOborot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOstatokAndOborot.Name = "buttonOstatokAndOborot";
            this.buttonOstatokAndOborot.Size = new System.Drawing.Size(188, 31);
            this.buttonOstatokAndOborot.TabIndex = 76;
            this.buttonOstatokAndOborot.Text = "Залишки та обороти";
            this.buttonOstatokAndOborot.UseVisualStyleBackColor = true;
            this.buttonOstatokAndOborot.Click += new System.EventHandler(this.buttonOstatokAndOborot_Click);
            // 
            // button_Documents
            // 
            this.button_Documents.Location = new System.Drawing.Point(316, 183);
            this.button_Documents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.Size = new System.Drawing.Size(112, 31);
            this.button_Documents.TabIndex = 78;
            this.button_Documents.Text = "По документах";
            this.button_Documents.UseVisualStyleBackColor = true;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // directoryControl_Серія
            // 
            this.directoryControl_Серія.AfterSelectFunc = null;
            this.directoryControl_Серія.BeforeClickOpenFunc = null;
            this.directoryControl_Серія.BeforeFindFunc = null;
            this.directoryControl_Серія.Bind = null;
            this.directoryControl_Серія.DirectoryPointerItem = null;
            this.directoryControl_Серія.Location = new System.Drawing.Point(631, 141);
            this.directoryControl_Серія.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Серія.Name = "directoryControl_Серія";
            this.directoryControl_Серія.QueryFind = null;
            this.directoryControl_Серія.SelectForm = null;
            this.directoryControl_Серія.Size = new System.Drawing.Size(385, 27);
            this.directoryControl_Серія.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Серія:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 25);
            this.label8.TabIndex = 87;
            this.label8.Text = "Товари на складах";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.label8);
            this.splitContainer.Panel1.Controls.Add(this.dateTimeStart);
            this.splitContainer.Panel1.Controls.Add(this.directoryControl_Серія);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.label7);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.button_Documents);
            this.splitContainer.Panel1.Controls.Add(this.dateTimeStop);
            this.splitContainer.Panel1.Controls.Add(this.buttonOstatokAndOborot);
            this.splitContainer.Panel1.Controls.Add(this.buttonClose);
            this.splitContainer.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer.Panel1.Controls.Add(this.buttonOstatok);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Size = new System.Drawing.Size(1045, 576);
            this.splitContainer.SplitterDistance = 226;
            this.splitContainer.TabIndex = 88;
            // 
            // Form_ТовариНаСкладах_Звіт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 576);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ТовариНаСкладах_Звіт";
            this.Text = "Звіт \"Товари на складах\"";
            this.Load += new System.EventHandler(this.Form_ЗамовленняКлієнтів_Звіт_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.Label label9;
        private DirectoryControl directoryControl_НоменклатураПапка;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_Номенклатура;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_СкладиПапки;
        private System.Windows.Forms.Label label5;
        private DirectoryControl directoryControl_Склади;
        private System.Windows.Forms.Label label6;
        private DirectoryControl directoryControl_ХарактеристикаНоменклатури;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOstatok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOstatokAndOborot;
        private System.Windows.Forms.Button button_Documents;
        private DirectoryControl directoryControl_Серія;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}