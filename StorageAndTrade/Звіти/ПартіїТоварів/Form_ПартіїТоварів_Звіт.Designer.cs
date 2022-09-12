
namespace StorageAndTrade
{
    partial class Form_ПартіїТоварів_Звіт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ПартіїТоварів_Звіт));
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOstatok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.directoryControl_НоменклатураПапка = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Номенклатура = new StorageAndTrade.DirectoryControl();
            this.directoryControl_ХарактеристикаНоменклатури = new StorageAndTrade.DirectoryControl();
            this.button_Documents = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.directoryControl_Організація = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Серія = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Склад = new StorageAndTrade.DirectoryControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(230, 12);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(227, 23);
            this.dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Період з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.Location = new System.Drawing.Point(494, 13);
            this.dateTimeStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(227, 23);
            this.dateTimeStop.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Папка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Номенклатура:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "Характеристика:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(938, 210);
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
            this.buttonOstatok.Location = new System.Drawing.Point(14, 210);
            this.buttonOstatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOstatok.Name = "buttonOstatok";
            this.buttonOstatok.Size = new System.Drawing.Size(105, 31);
            this.buttonOstatok.TabIndex = 73;
            this.buttonOstatok.Text = "Залишки";
            this.buttonOstatok.UseVisualStyleBackColor = true;
            this.buttonOstatok.Click += new System.EventHandler(this.buttonOstatok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.directoryControl_НоменклатураПапка);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.directoryControl_Номенклатура);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.directoryControl_ХарактеристикаНоменклатури);
            this.groupBox1.Location = new System.Drawing.Point(14, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(570, 147);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номенклатура";
            // 
            // directoryControl_НоменклатураПапка
            // 
            this.directoryControl_НоменклатураПапка.AfterSelectFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeClickOpenFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeFindFunc = null;
            this.directoryControl_НоменклатураПапка.Bind = null;
            this.directoryControl_НоменклатураПапка.DirectoryPointerItem = null;
            this.directoryControl_НоменклатураПапка.Location = new System.Drawing.Point(132, 22);
            this.directoryControl_НоменклатураПапка.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_НоменклатураПапка.Name = "directoryControl_НоменклатураПапка";
            this.directoryControl_НоменклатураПапка.QueryFind = null;
            this.directoryControl_НоменклатураПапка.SelectForm = null;
            this.directoryControl_НоменклатураПапка.Size = new System.Drawing.Size(416, 31);
            this.directoryControl_НоменклатураПапка.TabIndex = 55;
            // 
            // directoryControl_Номенклатура
            // 
            this.directoryControl_Номенклатура.AfterSelectFunc = null;
            this.directoryControl_Номенклатура.BeforeClickOpenFunc = null;
            this.directoryControl_Номенклатура.BeforeFindFunc = null;
            this.directoryControl_Номенклатура.Bind = null;
            this.directoryControl_Номенклатура.DirectoryPointerItem = null;
            this.directoryControl_Номенклатура.Location = new System.Drawing.Point(132, 60);
            this.directoryControl_Номенклатура.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Номенклатура.Name = "directoryControl_Номенклатура";
            this.directoryControl_Номенклатура.QueryFind = null;
            this.directoryControl_Номенклатура.SelectForm = null;
            this.directoryControl_Номенклатура.Size = new System.Drawing.Size(416, 31);
            this.directoryControl_Номенклатура.TabIndex = 57;
            // 
            // directoryControl_ХарактеристикаНоменклатури
            // 
            this.directoryControl_ХарактеристикаНоменклатури.AfterSelectFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.BeforeClickOpenFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.BeforeFindFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.Bind = null;
            this.directoryControl_ХарактеристикаНоменклатури.DirectoryPointerItem = null;
            this.directoryControl_ХарактеристикаНоменклатури.Location = new System.Drawing.Point(132, 98);
            this.directoryControl_ХарактеристикаНоменклатури.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_ХарактеристикаНоменклатури.Name = "directoryControl_ХарактеристикаНоменклатури";
            this.directoryControl_ХарактеристикаНоменклатури.QueryFind = null;
            this.directoryControl_ХарактеристикаНоменклатури.SelectForm = null;
            this.directoryControl_ХарактеристикаНоменклатури.Size = new System.Drawing.Size(416, 31);
            this.directoryControl_ХарактеристикаНоменклатури.TabIndex = 63;
            // 
            // button_Documents
            // 
            this.button_Documents.Location = new System.Drawing.Point(126, 210);
            this.button_Documents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.Size = new System.Drawing.Size(112, 31);
            this.button_Documents.TabIndex = 78;
            this.button_Documents.Text = "По документах";
            this.button_Documents.UseVisualStyleBackColor = true;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Серія:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Організація:";
            // 
            // directoryControl_Організація
            // 
            this.directoryControl_Організація.AfterSelectFunc = null;
            this.directoryControl_Організація.BeforeClickOpenFunc = null;
            this.directoryControl_Організація.BeforeFindFunc = null;
            this.directoryControl_Організація.Bind = null;
            this.directoryControl_Організація.DirectoryPointerItem = null;
            this.directoryControl_Організація.Location = new System.Drawing.Point(687, 72);
            this.directoryControl_Організація.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Організація.Name = "directoryControl_Організація";
            this.directoryControl_Організація.QueryFind = null;
            this.directoryControl_Організація.SelectForm = null;
            this.directoryControl_Організація.Size = new System.Drawing.Size(356, 31);
            this.directoryControl_Організація.TabIndex = 65;
            // 
            // directoryControl_Серія
            // 
            this.directoryControl_Серія.AfterSelectFunc = null;
            this.directoryControl_Серія.BeforeClickOpenFunc = null;
            this.directoryControl_Серія.BeforeFindFunc = null;
            this.directoryControl_Серія.Bind = null;
            this.directoryControl_Серія.DirectoryPointerItem = null;
            this.directoryControl_Серія.Location = new System.Drawing.Point(687, 148);
            this.directoryControl_Серія.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Серія.Name = "directoryControl_Серія";
            this.directoryControl_Серія.QueryFind = null;
            this.directoryControl_Серія.SelectForm = null;
            this.directoryControl_Серія.Size = new System.Drawing.Size(356, 31);
            this.directoryControl_Серія.TabIndex = 63;
            // 
            // directoryControl_Склад
            // 
            this.directoryControl_Склад.AfterSelectFunc = null;
            this.directoryControl_Склад.BeforeClickOpenFunc = null;
            this.directoryControl_Склад.BeforeFindFunc = null;
            this.directoryControl_Склад.Bind = null;
            this.directoryControl_Склад.DirectoryPointerItem = null;
            this.directoryControl_Склад.Location = new System.Drawing.Point(687, 110);
            this.directoryControl_Склад.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Склад.Name = "directoryControl_Склад";
            this.directoryControl_Склад.QueryFind = null;
            this.directoryControl_Склад.SelectForm = null;
            this.directoryControl_Склад.Size = new System.Drawing.Size(356, 31);
            this.directoryControl_Склад.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 80;
            this.label5.Text = "Склад:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 83;
            this.label8.Text = "Партії товарів";
            // 
            // Form_ПартіїТоварів_Звіт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 490);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.directoryControl_Склад);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.directoryControl_Організація);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directoryControl_Серія);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Documents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOstatok);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dateTimeStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ПартіїТоварів_Звіт";
            this.Text = "Звіт \"Партії товарів\"";
            this.Load += new System.EventHandler(this.Form_ПартіїТоварів_Звіт_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private DirectoryControl directoryControl_ХарактеристикаНоменклатури;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOstatok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Documents;
        private DirectoryControl directoryControl_Серія;
        private System.Windows.Forms.Label label7;
        private DirectoryControl directoryControl_Організація;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_Склад;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}