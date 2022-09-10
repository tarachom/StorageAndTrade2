
namespace StorageAndTrade
{
    partial class Form_РухКоштів_Звіт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_РухКоштів_Звіт));
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Report = new System.Windows.Forms.Button();
            this.directoryControl_Каса = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Організація = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Валюти = new StorageAndTrade.DirectoryControl();
            this.button_Documents = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(205, 12);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(215, 23);
            this.dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Період з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.Location = new System.Drawing.Point(457, 12);
            this.dateTimeStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(216, 23);
            this.dateTimeStop.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(14, 170);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 31);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Залишки коштів";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Валюта:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(586, 170);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 31);
            this.buttonClose.TabIndex = 70;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "Організація:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "Каса:";
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(141, 170);
            this.button_Report.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(142, 31);
            this.button_Report.TabIndex = 76;
            this.button_Report.Text = "Залишки та обороти";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // directoryControl_Каса
            // 
            this.directoryControl_Каса.AfterSelectFunc = null;
            this.directoryControl_Каса.BeforeClickOpenFunc = null;
            this.directoryControl_Каса.BeforeFindFunc = null;
            this.directoryControl_Каса.Bind = null;
            this.directoryControl_Каса.DirectoryPointerItem = null;
            this.directoryControl_Каса.Location = new System.Drawing.Point(107, 89);
            this.directoryControl_Каса.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Каса.Name = "directoryControl_Каса";
            this.directoryControl_Каса.QueryFind = null;
            this.directoryControl_Каса.SelectForm = null;
            this.directoryControl_Каса.Size = new System.Drawing.Size(469, 31);
            this.directoryControl_Каса.TabIndex = 74;
            // 
            // directoryControl_Організація
            // 
            this.directoryControl_Організація.AfterSelectFunc = null;
            this.directoryControl_Організація.BeforeClickOpenFunc = null;
            this.directoryControl_Організація.BeforeFindFunc = null;
            this.directoryControl_Організація.Bind = null;
            this.directoryControl_Організація.DirectoryPointerItem = null;
            this.directoryControl_Організація.Location = new System.Drawing.Point(107, 51);
            this.directoryControl_Організація.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Організація.Name = "directoryControl_Організація";
            this.directoryControl_Організація.QueryFind = null;
            this.directoryControl_Організація.SelectForm = null;
            this.directoryControl_Організація.Size = new System.Drawing.Size(469, 31);
            this.directoryControl_Організація.TabIndex = 72;
            // 
            // directoryControl_Валюти
            // 
            this.directoryControl_Валюти.AfterSelectFunc = null;
            this.directoryControl_Валюти.BeforeClickOpenFunc = null;
            this.directoryControl_Валюти.BeforeFindFunc = null;
            this.directoryControl_Валюти.Bind = null;
            this.directoryControl_Валюти.DirectoryPointerItem = null;
            this.directoryControl_Валюти.Location = new System.Drawing.Point(107, 127);
            this.directoryControl_Валюти.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Валюти.Name = "directoryControl_Валюти";
            this.directoryControl_Валюти.QueryFind = null;
            this.directoryControl_Валюти.SelectForm = null;
            this.directoryControl_Валюти.Size = new System.Drawing.Size(469, 31);
            this.directoryControl_Валюти.TabIndex = 61;
            // 
            // button_Documents
            // 
            this.button_Documents.Location = new System.Drawing.Point(290, 170);
            this.button_Documents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.Size = new System.Drawing.Size(112, 31);
            this.button_Documents.TabIndex = 77;
            this.button_Documents.Text = "По документах";
            this.button_Documents.UseVisualStyleBackColor = true;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 86;
            this.label8.Text = "Рух коштів";
            // 
            // Form_РухКоштів_Звіт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 663);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Documents);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.directoryControl_Каса);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directoryControl_Організація);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.directoryControl_Валюти);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dateTimeStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_РухКоштів_Звіт";
            this.Text = "Звіт \"Рух коштів\"";
            this.Load += new System.EventHandler(this.Form_РухКоштів_Звіт_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label5;
        private DirectoryControl directoryControl_Валюти;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_Організація;
        private System.Windows.Forms.Label label6;
        private DirectoryControl directoryControl_Каса;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Button button_Documents;
        private System.Windows.Forms.Label label8;
    }
}