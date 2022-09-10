
namespace StorageAndTrade
{
    partial class Form_ВільніЗалишки_Звіт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ВільніЗалишки_Звіт));
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.buttonOstatok = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.directoryControl_ХарактеристикаНоменклатури = new StorageAndTrade.DirectoryControl();
            this.directoryControl_НоменклатураПапка = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Номенклатура = new StorageAndTrade.DirectoryControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.directoryControl_Склади = new StorageAndTrade.DirectoryControl();
            this.directoryControl_СкладиПапки = new StorageAndTrade.DirectoryControl();
            this.buttonDocuments = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.documentControl_ЗамовленняКлієнта = new StorageAndTrade.DocumentControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(242, 12);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(226, 23);
            this.dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Період з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.Location = new System.Drawing.Point(504, 12);
            this.dateTimeStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(226, 23);
            this.dateTimeStop.TabIndex = 3;
            // 
            // buttonOstatok
            // 
            this.buttonOstatok.Location = new System.Drawing.Point(14, 198);
            this.buttonOstatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOstatok.Name = "buttonOstatok";
            this.buttonOstatok.Size = new System.Drawing.Size(181, 31);
            this.buttonOstatok.TabIndex = 4;
            this.buttonOstatok.Text = "Вільні залишки та резерви";
            this.buttonOstatok.UseVisualStyleBackColor = true;
            this.buttonOstatok.Click += new System.EventHandler(this.buttonOstatok_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Папка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Номенклатура:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Папка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Склад:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "Замовлення клієнта:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Характеристика:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(990, 198);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 31);
            this.buttonClose.TabIndex = 68;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.directoryControl_ХарактеристикаНоменклатури);
            this.groupBox1.Controls.Add(this.directoryControl_НоменклатураПапка);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.directoryControl_Номенклатура);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(568, 142);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номенклатура";
            // 
            // directoryControl_ХарактеристикаНоменклатури
            // 
            this.directoryControl_ХарактеристикаНоменклатури.AfterSelectFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.BeforeClickOpenFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.BeforeFindFunc = null;
            this.directoryControl_ХарактеристикаНоменклатури.Bind = null;
            this.directoryControl_ХарактеристикаНоменклатури.DirectoryPointerItem = null;
            this.directoryControl_ХарактеристикаНоменклатури.Location = new System.Drawing.Point(126, 95);
            this.directoryControl_ХарактеристикаНоменклатури.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_ХарактеристикаНоменклатури.Name = "directoryControl_ХарактеристикаНоменклатури";
            this.directoryControl_ХарактеристикаНоменклатури.QueryFind = null;
            this.directoryControl_ХарактеристикаНоменклатури.SelectForm = null;
            this.directoryControl_ХарактеристикаНоменклатури.Size = new System.Drawing.Size(427, 31);
            this.directoryControl_ХарактеристикаНоменклатури.TabIndex = 66;
            // 
            // directoryControl_НоменклатураПапка
            // 
            this.directoryControl_НоменклатураПапка.AfterSelectFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeClickOpenFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeFindFunc = null;
            this.directoryControl_НоменклатураПапка.Bind = null;
            this.directoryControl_НоменклатураПапка.DirectoryPointerItem = null;
            this.directoryControl_НоменклатураПапка.Location = new System.Drawing.Point(126, 18);
            this.directoryControl_НоменклатураПапка.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_НоменклатураПапка.Name = "directoryControl_НоменклатураПапка";
            this.directoryControl_НоменклатураПапка.QueryFind = null;
            this.directoryControl_НоменклатураПапка.SelectForm = null;
            this.directoryControl_НоменклатураПапка.Size = new System.Drawing.Size(427, 31);
            this.directoryControl_НоменклатураПапка.TabIndex = 55;
            // 
            // directoryControl_Номенклатура
            // 
            this.directoryControl_Номенклатура.AfterSelectFunc = null;
            this.directoryControl_Номенклатура.BeforeClickOpenFunc = null;
            this.directoryControl_Номенклатура.BeforeFindFunc = null;
            this.directoryControl_Номенклатура.Bind = null;
            this.directoryControl_Номенклатура.DirectoryPointerItem = null;
            this.directoryControl_Номенклатура.Location = new System.Drawing.Point(126, 57);
            this.directoryControl_Номенклатура.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Номенклатура.Name = "directoryControl_Номенклатура";
            this.directoryControl_Номенклатура.QueryFind = null;
            this.directoryControl_Номенклатура.SelectForm = null;
            this.directoryControl_Номенклатура.Size = new System.Drawing.Size(427, 31);
            this.directoryControl_Номенклатура.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.directoryControl_Склади);
            this.groupBox2.Controls.Add(this.directoryControl_СкладиПапки);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(589, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(509, 103);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Склад";
            // 
            // directoryControl_Склади
            // 
            this.directoryControl_Склади.AfterSelectFunc = null;
            this.directoryControl_Склади.BeforeClickOpenFunc = null;
            this.directoryControl_Склади.BeforeFindFunc = null;
            this.directoryControl_Склади.Bind = null;
            this.directoryControl_Склади.DirectoryPointerItem = null;
            this.directoryControl_Склади.Location = new System.Drawing.Point(66, 55);
            this.directoryControl_Склади.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Склади.Name = "directoryControl_Склади";
            this.directoryControl_Склади.QueryFind = null;
            this.directoryControl_Склади.SelectForm = null;
            this.directoryControl_Склади.Size = new System.Drawing.Size(422, 31);
            this.directoryControl_Склади.TabIndex = 61;
            // 
            // directoryControl_СкладиПапки
            // 
            this.directoryControl_СкладиПапки.AfterSelectFunc = null;
            this.directoryControl_СкладиПапки.BeforeClickOpenFunc = null;
            this.directoryControl_СкладиПапки.BeforeFindFunc = null;
            this.directoryControl_СкладиПапки.Bind = null;
            this.directoryControl_СкладиПапки.DirectoryPointerItem = null;
            this.directoryControl_СкладиПапки.Location = new System.Drawing.Point(66, 17);
            this.directoryControl_СкладиПапки.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_СкладиПапки.Name = "directoryControl_СкладиПапки";
            this.directoryControl_СкладиПапки.QueryFind = null;
            this.directoryControl_СкладиПапки.SelectForm = null;
            this.directoryControl_СкладиПапки.Size = new System.Drawing.Size(422, 31);
            this.directoryControl_СкладиПапки.TabIndex = 59;
            // 
            // buttonDocuments
            // 
            this.buttonDocuments.Location = new System.Drawing.Point(202, 198);
            this.buttonDocuments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDocuments.Name = "buttonDocuments";
            this.buttonDocuments.Size = new System.Drawing.Size(112, 31);
            this.buttonDocuments.TabIndex = 79;
            this.buttonDocuments.Text = "По документах";
            this.buttonDocuments.UseVisualStyleBackColor = true;
            this.buttonDocuments.Click += new System.EventHandler(this.buttonDocuments_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "Вільні залишки";
            // 
            // documentControl_ЗамовленняКлієнта
            // 
            this.documentControl_ЗамовленняКлієнта.DocumentPointerItem = null;
            this.documentControl_ЗамовленняКлієнта.Location = new System.Drawing.Point(729, 157);
            this.documentControl_ЗамовленняКлієнта.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.documentControl_ЗамовленняКлієнта.Name = "documentControl_ЗамовленняКлієнта";
            this.documentControl_ЗамовленняКлієнта.SelectForm = null;
            this.documentControl_ЗамовленняКлієнта.Size = new System.Drawing.Size(369, 31);
            this.documentControl_ЗамовленняКлієнта.TabIndex = 65;
            // 
            // Form_ВільніЗалишки_Звіт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 695);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDocuments);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.documentControl_ЗамовленняКлієнта);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeStop);
            this.Controls.Add(this.buttonOstatok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ВільніЗалишки_Звіт";
            this.Text = "Звіт \"Вільні залишки\"";
            this.Load += new System.EventHandler(this.Form_ВільніЗалишки_Звіт_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.Button buttonOstatok;
        private System.Windows.Forms.Label label9;
        private DirectoryControl directoryControl_НоменклатураПапка;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_Номенклатура;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_СкладиПапки;
        private System.Windows.Forms.Label label5;
        private DirectoryControl directoryControl_Склади;
        private System.Windows.Forms.Label label6;
        private DocumentControl documentControl_ЗамовленняКлієнта;
        private System.Windows.Forms.Label label7;
        private DirectoryControl directoryControl_ХарактеристикаНоменклатури;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDocuments;
        private System.Windows.Forms.Label label8;
    }
}