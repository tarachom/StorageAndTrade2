﻿
namespace StorageAndTrade
{
    partial class Form_СкладиЕлемент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_СкладиЕлемент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxНазва = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ТипСкладу = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryControl_Відповідальний = new StorageAndTrade.DirectoryControl();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryControl_ВидЦін = new StorageAndTrade.DirectoryControl();
            this.label4 = new System.Windows.Forms.Label();
            this.directoryControl_Підрозділ = new StorageAndTrade.DirectoryControl();
            this.label9 = new System.Windows.Forms.Label();
            this.directoryControl_СкладиПапка = new StorageAndTrade.DirectoryControl();
            this.textBox_Код = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Склади_ТабличнаЧастина_Контакти = new StorageAndTrade.Form_Склади_ТабличнаЧастина_Контакти();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(331, 602);
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
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(12, 602);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxНазва
            // 
            this.textBoxНазва.AcceptsTab = true;
            this.textBoxНазва.Location = new System.Drawing.Point(128, 14);
            this.textBoxНазва.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxНазва.Name = "textBoxНазва";
            this.textBoxНазва.Size = new System.Drawing.Size(510, 23);
            this.textBoxНазва.TabIndex = 20;
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
            // comboBox_ТипСкладу
            // 
            this.comboBox_ТипСкладу.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ТипСкладу.FormattingEnabled = true;
            this.comboBox_ТипСкладу.Location = new System.Drawing.Point(128, 82);
            this.comboBox_ТипСкладу.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ТипСкладу.Name = "comboBox_ТипСкладу";
            this.comboBox_ТипСкладу.Size = new System.Drawing.Size(299, 23);
            this.comboBox_ТипСкладу.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Тип:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Відповідальний:";
            // 
            // directoryControl_Відповідальний
            // 
            this.directoryControl_Відповідальний.AfterSelectFunc = null;
            this.directoryControl_Відповідальний.BeforeClickOpenFunc = null;
            this.directoryControl_Відповідальний.BeforeFindFunc = null;
            this.directoryControl_Відповідальний.Bind = null;
            this.directoryControl_Відповідальний.DirectoryPointerItem = null;
            this.directoryControl_Відповідальний.Location = new System.Drawing.Point(128, 118);
            this.directoryControl_Відповідальний.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Відповідальний.Name = "directoryControl_Відповідальний";
            this.directoryControl_Відповідальний.QueryFind = null;
            this.directoryControl_Відповідальний.SelectForm = null;
            this.directoryControl_Відповідальний.Size = new System.Drawing.Size(511, 31);
            this.directoryControl_Відповідальний.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Вид цін:";
            // 
            // directoryControl_ВидЦін
            // 
            this.directoryControl_ВидЦін.AfterSelectFunc = null;
            this.directoryControl_ВидЦін.BeforeClickOpenFunc = null;
            this.directoryControl_ВидЦін.BeforeFindFunc = null;
            this.directoryControl_ВидЦін.Bind = null;
            this.directoryControl_ВидЦін.DirectoryPointerItem = null;
            this.directoryControl_ВидЦін.Location = new System.Drawing.Point(128, 156);
            this.directoryControl_ВидЦін.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_ВидЦін.Name = "directoryControl_ВидЦін";
            this.directoryControl_ВидЦін.QueryFind = null;
            this.directoryControl_ВидЦін.SelectForm = null;
            this.directoryControl_ВидЦін.Size = new System.Drawing.Size(511, 31);
            this.directoryControl_ВидЦін.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Підрозділ:";
            // 
            // directoryControl_Підрозділ
            // 
            this.directoryControl_Підрозділ.AfterSelectFunc = null;
            this.directoryControl_Підрозділ.BeforeClickOpenFunc = null;
            this.directoryControl_Підрозділ.BeforeFindFunc = null;
            this.directoryControl_Підрозділ.Bind = null;
            this.directoryControl_Підрозділ.DirectoryPointerItem = null;
            this.directoryControl_Підрозділ.Location = new System.Drawing.Point(128, 194);
            this.directoryControl_Підрозділ.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Підрозділ.Name = "directoryControl_Підрозділ";
            this.directoryControl_Підрозділ.QueryFind = null;
            this.directoryControl_Підрозділ.SelectForm = null;
            this.directoryControl_Підрозділ.Size = new System.Drawing.Size(511, 31);
            this.directoryControl_Підрозділ.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Папка:";
            // 
            // directoryControl_СкладиПапка
            // 
            this.directoryControl_СкладиПапка.AfterSelectFunc = null;
            this.directoryControl_СкладиПапка.BeforeClickOpenFunc = null;
            this.directoryControl_СкладиПапка.BeforeFindFunc = null;
            this.directoryControl_СкладиПапка.Bind = null;
            this.directoryControl_СкладиПапка.DirectoryPointerItem = null;
            this.directoryControl_СкладиПапка.Location = new System.Drawing.Point(128, 44);
            this.directoryControl_СкладиПапка.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_СкладиПапка.Name = "directoryControl_СкладиПапка";
            this.directoryControl_СкладиПапка.QueryFind = null;
            this.directoryControl_СкладиПапка.SelectForm = null;
            this.directoryControl_СкладиПапка.Size = new System.Drawing.Size(511, 31);
            this.directoryControl_СкладиПапка.TabIndex = 55;
            // 
            // textBox_Код
            // 
            this.textBox_Код.AcceptsTab = true;
            this.textBox_Код.Location = new System.Drawing.Point(696, 14);
            this.textBox_Код.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Код.Name = "textBox_Код";
            this.textBox_Код.Size = new System.Drawing.Size(134, 23);
            this.textBox_Код.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Код:";
            // 
            // Склади_ТабличнаЧастина_Контакти
            // 
            this.Склади_ТабличнаЧастина_Контакти.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Склади_ТабличнаЧастина_Контакти.Location = new System.Drawing.Point(12, 246);
            this.Склади_ТабличнаЧастина_Контакти.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Склади_ТабличнаЧастина_Контакти.Name = "Склади_ТабличнаЧастина_Контакти";
            this.Склади_ТабличнаЧастина_Контакти.Size = new System.Drawing.Size(821, 338);
            this.Склади_ТабличнаЧастина_Контакти.TabIndex = 59;
            this.Склади_ТабличнаЧастина_Контакти.ДовідникОбєкт = null;
            // 
            // Form_СкладиЕлемент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 647);
            this.Controls.Add(this.Склади_ТабличнаЧастина_Контакти);
            this.Controls.Add(this.textBox_Код);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.directoryControl_СкладиПапка);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directoryControl_Підрозділ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.directoryControl_ВидЦін);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryControl_Відповідальний);
            this.Controls.Add(this.comboBox_ТипСкладу);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxНазва);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_СкладиЕлемент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склади";
            this.Load += new System.EventHandler(this.Form_СкладиЕлемент_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxНазва;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ТипСкладу;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DirectoryControl directoryControl_Відповідальний;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_ВидЦін;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_Підрозділ;
        private System.Windows.Forms.Label label9;
        private DirectoryControl directoryControl_СкладиПапка;
        private System.Windows.Forms.TextBox textBox_Код;
        private System.Windows.Forms.Label label6;
        private Form_Склади_ТабличнаЧастина_Контакти Склади_ТабличнаЧастина_Контакти;
    }
}