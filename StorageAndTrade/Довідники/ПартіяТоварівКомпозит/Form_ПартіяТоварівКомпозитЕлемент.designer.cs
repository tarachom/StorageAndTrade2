﻿
namespace StorageAndTrade
{
    partial class Form_ПартіяТоварівКомпозитЕлемент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ПартіяТоварівКомпозитЕлемент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Дата = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.documentControl_ВведенняЗалишків = new StorageAndTrade.DocumentControl();
            this.documentControl_ПоступленняТоварів = new StorageAndTrade.DocumentControl();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(234, 175);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(191, 31);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(234, 14);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(434, 23);
            this.textBoxName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Назва:";
            // 
            // dateTimePicker_Дата
            // 
            this.dateTimePicker_Дата.Location = new System.Drawing.Point(234, 47);
            this.dateTimePicker_Дата.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_Дата.Name = "dateTimePicker_Дата";
            this.dateTimePicker_Дата.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker_Дата.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Документ поступлення товарів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Документ введення залишків:";
            // 
            // documentControl_ВведенняЗалишків
            // 
            this.documentControl_ВведенняЗалишків.DocumentPointerItem = null;
            this.documentControl_ВведенняЗалишків.Location = new System.Drawing.Point(234, 117);
            this.documentControl_ВведенняЗалишків.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.documentControl_ВведенняЗалишків.Name = "documentControl_ВведенняЗалишків";
            this.documentControl_ВведенняЗалишків.SelectForm = null;
            this.documentControl_ВведенняЗалишків.Size = new System.Drawing.Size(434, 27);
            this.documentControl_ВведенняЗалишків.TabIndex = 69;
            // 
            // documentControl_ПоступленняТоварів
            // 
            this.documentControl_ПоступленняТоварів.DocumentPointerItem = null;
            this.documentControl_ПоступленняТоварів.Location = new System.Drawing.Point(234, 78);
            this.documentControl_ПоступленняТоварів.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.documentControl_ПоступленняТоварів.Name = "documentControl_ПоступленняТоварів";
            this.documentControl_ПоступленняТоварів.SelectForm = null;
            this.documentControl_ПоступленняТоварів.Size = new System.Drawing.Size(434, 27);
            this.documentControl_ПоступленняТоварів.TabIndex = 67;
            // 
            // Form_ПартіяТоварівКомпозитЕлемент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 223);
            this.Controls.Add(this.documentControl_ВведенняЗалишків);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.documentControl_ПоступленняТоварів);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Дата);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ПартіяТоварівКомпозитЕлемент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Партія товарів композит";
            this.Load += new System.EventHandler(this.Form_ПартіяТоварівКомпозит_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Дата;
        private System.Windows.Forms.Label label1;
        private DocumentControl documentControl_ПоступленняТоварів;
        private System.Windows.Forms.Label label6;
        private DocumentControl documentControl_ВведенняЗалишків;
        private System.Windows.Forms.Label label3;
    }
}