
namespace StorageAndTrade
{
    partial class Form_ЗавантаженняКурсівВалют
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ЗавантаженняКурсівВалют));
            this.buttonDownloadExCurr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_НаВказануДату = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1_ДатаКурсу = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDownloadExCurr
            // 
            this.buttonDownloadExCurr.Location = new System.Drawing.Point(4, 50);
            this.buttonDownloadExCurr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDownloadExCurr.Name = "buttonDownloadExCurr";
            this.buttonDownloadExCurr.Size = new System.Drawing.Size(106, 31);
            this.buttonDownloadExCurr.TabIndex = 0;
            this.buttonDownloadExCurr.Text = "Завантажити";
            this.buttonDownloadExCurr.UseVisualStyleBackColor = true;
            this.buttonDownloadExCurr.Click += new System.EventHandler(this.buttonDownloadExCurr_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkBox_НаВказануДату);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1_ДатаКурсу);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonDownloadExCurr);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 84);
            this.panel1.TabIndex = 1;
            // 
            // checkBox_НаВказануДату
            // 
            this.checkBox_НаВказануДату.AutoSize = true;
            this.checkBox_НаВказануДату.Location = new System.Drawing.Point(12, 15);
            this.checkBox_НаВказануДату.Name = "checkBox_НаВказануДату";
            this.checkBox_НаВказануДату.Size = new System.Drawing.Size(212, 19);
            this.checkBox_НаВказануДату.TabIndex = 4;
            this.checkBox_НаВказануДату.Text = "Завантажити курс на вказану дату";
            this.checkBox_НаВказануДату.UseVisualStyleBackColor = true;
            this.checkBox_НаВказануДату.CheckedChanged += new System.EventHandler(this.checkBox_НаВказануДату_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(242, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата:";
            // 
            // dateTimePicker1_ДатаКурсу
            // 
            this.dateTimePicker1_ДатаКурсу.Enabled = false;
            this.dateTimePicker1_ДатаКурсу.Location = new System.Drawing.Point(283, 13);
            this.dateTimePicker1_ДатаКурсу.Name = "dateTimePicker1_ДатаКурсу";
            this.dateTimePicker1_ДатаКурсу.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1_ДатаКурсу.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(283, 50);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Зупинити";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.richTextBoxInfo);
            this.panel2.Location = new System.Drawing.Point(4, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 470);
            this.panel2.TabIndex = 1;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(653, 470);
            this.richTextBoxInfo.TabIndex = 1;
            this.richTextBoxInfo.Text = "";
            // 
            // Form_ЗавантаженняКурсівВалют
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ЗавантаженняКурсівВалют";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завантаження курсів валют";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ЗавантаженняКурсівВалют_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDownloadExCurr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ДатаКурсу;
        private System.Windows.Forms.CheckBox checkBox_НаВказануДату;
    }
}