
namespace StorageAndTrade
{
    partial class Form_КурсиВалютЕлемент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_КурсиВалютЕлемент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryControl_Валюта = new StorageAndTrade.DirectoryControl();
            this.label3 = new System.Windows.Forms.Label();
            this.numericControlКурс = new StorageAndTrade.NumericControl();
            this.dateTimePicker_Дата = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(398, 135);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 31);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(73, 135);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Курс:";
            // 
            // directoryControl_Валюта
            // 
            this.directoryControl_Валюта.AfterSelectFunc = null;
            this.directoryControl_Валюта.BeforeClickOpenFunc = null;
            this.directoryControl_Валюта.BeforeFindFunc = null;
            this.directoryControl_Валюта.Bind = null;
            this.directoryControl_Валюта.DirectoryPointerItem = null;
            this.directoryControl_Валюта.Location = new System.Drawing.Point(73, 50);
            this.directoryControl_Валюта.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Валюта.Name = "directoryControl_Валюта";
            this.directoryControl_Валюта.QueryFind = null;
            this.directoryControl_Валюта.SelectForm = null;
            this.directoryControl_Валюта.Size = new System.Drawing.Size(445, 27);
            this.directoryControl_Валюта.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Валюта:";
            // 
            // numericControlКурс
            // 
            this.numericControlКурс.Location = new System.Drawing.Point(73, 87);
            this.numericControlКурс.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericControlКурс.Name = "numericControlКурс";
            this.numericControlКурс.Size = new System.Drawing.Size(239, 23);
            this.numericControlКурс.TabIndex = 70;
            this.numericControlКурс.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dateTimePicker_Дата
            // 
            this.dateTimePicker_Дата.Location = new System.Drawing.Point(73, 17);
            this.dateTimePicker_Дата.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_Дата.Name = "dateTimePicker_Дата";
            this.dateTimePicker_Дата.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker_Дата.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Дата:";
            // 
            // Form_КурсиВалютЕлемент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 191);
            this.Controls.Add(this.dateTimePicker_Дата);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericControlКурс);
            this.Controls.Add(this.directoryControl_Валюта);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_КурсиВалютЕлемент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курс валюти";
            this.Load += new System.EventHandler(this.Form_КурсиВалютЕлемент_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private DirectoryControl directoryControl_Валюта;
        private System.Windows.Forms.Label label3;
        private NumericControl numericControlКурс;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Дата;
        private System.Windows.Forms.Label label1;
    }
}