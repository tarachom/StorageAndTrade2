
namespace StorageAndTrade
{
    partial class Form_ФайлиДокументівЕлемент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ФайлиДокументівЕлемент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.directoryControl_Файл = new StorageAndTrade.DirectoryControl();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Дата = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(398, 94);
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
            this.buttonSave.Location = new System.Drawing.Point(61, 94);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // directoryControl_Файл
            // 
            this.directoryControl_Файл.AfterSelectFunc = null;
            this.directoryControl_Файл.BeforeClickOpenFunc = null;
            this.directoryControl_Файл.BeforeFindFunc = null;
            this.directoryControl_Файл.Bind = null;
            this.directoryControl_Файл.DirectoryPointerItem = null;
            this.directoryControl_Файл.Location = new System.Drawing.Point(61, 46);
            this.directoryControl_Файл.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Файл.Name = "directoryControl_Файл";
            this.directoryControl_Файл.QueryFind = null;
            this.directoryControl_Файл.SelectForm = null;
            this.directoryControl_Файл.Size = new System.Drawing.Size(457, 27);
            this.directoryControl_Файл.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Файл:";
            // 
            // dateTimePicker_Дата
            // 
            this.dateTimePicker_Дата.Location = new System.Drawing.Point(61, 15);
            this.dateTimePicker_Дата.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_Дата.Name = "dateTimePicker_Дата";
            this.dateTimePicker_Дата.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker_Дата.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Дата:";
            // 
            // Form_ФайлиДокументівЕлемент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 151);
            this.Controls.Add(this.dateTimePicker_Дата);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryControl_Файл);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ФайлиДокументівЕлемент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файл документу";
            this.Load += new System.EventHandler(this.Form_ФайлиДокументівЕлемент_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private DirectoryControl directoryControl_Файл;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Дата;
        private System.Windows.Forms.Label label1;
    }
}