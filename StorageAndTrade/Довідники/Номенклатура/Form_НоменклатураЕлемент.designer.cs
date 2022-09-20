
namespace StorageAndTrade
{
    partial class Form_НоменклатураЕлемент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_НоменклатураЕлемент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox_Назва = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ТипНоменклатури = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.directoryControl_ОдиницяВиміру = new StorageAndTrade.DirectoryControl();
            this.directoryControl_ВидНоменклатури = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Виробник = new StorageAndTrade.DirectoryControl();
            this.textBox_Артикул = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_НазваПовна = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Опис = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.directoryControl_НоменклатураПапка = new StorageAndTrade.DirectoryControl();
            this.pictureBox_ОсновнаКартинка = new System.Windows.Forms.PictureBox();
            this.textBox_Код = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFileInput = new System.Windows.Forms.ToolStripButton();
            this.buttonOnlySave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ОсновнаКартинка)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(360, 577);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 31);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 576);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Зберегти і закрити";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox_Назва
            // 
            this.textBox_Назва.Location = new System.Drawing.Point(132, 37);
            this.textBox_Назва.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Назва.Name = "textBox_Назва";
            this.textBox_Назва.Size = new System.Drawing.Size(520, 23);
            this.textBox_Назва.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Назва:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Виробник:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Вид номенклатури:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Одиниця виміру:";
            // 
            // comboBox_ТипНоменклатури
            // 
            this.comboBox_ТипНоменклатури.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ТипНоменклатури.FormattingEnabled = true;
            this.comboBox_ТипНоменклатури.Location = new System.Drawing.Point(132, 168);
            this.comboBox_ТипНоменклатури.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ТипНоменклатури.Name = "comboBox_ТипНоменклатури";
            this.comboBox_ТипНоменклатури.Size = new System.Drawing.Size(299, 23);
            this.comboBox_ТипНоменклатури.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Тип:";
            // 
            // directoryControl_ОдиницяВиміру
            // 
            this.directoryControl_ОдиницяВиміру.AfterSelectFunc = null;
            this.directoryControl_ОдиницяВиміру.BeforeClickOpenFunc = null;
            this.directoryControl_ОдиницяВиміру.BeforeFindFunc = null;
            this.directoryControl_ОдиницяВиміру.Bind = null;
            this.directoryControl_ОдиницяВиміру.DirectoryPointerItem = null;
            this.directoryControl_ОдиницяВиміру.Location = new System.Drawing.Point(132, 258);
            this.directoryControl_ОдиницяВиміру.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_ОдиницяВиміру.Name = "directoryControl_ОдиницяВиміру";
            this.directoryControl_ОдиницяВиміру.QueryFind = null;
            this.directoryControl_ОдиницяВиміру.SelectForm = null;
            this.directoryControl_ОдиницяВиміру.Size = new System.Drawing.Size(301, 27);
            this.directoryControl_ОдиницяВиміру.TabIndex = 27;
            // 
            // directoryControl_ВидНоменклатури
            // 
            this.directoryControl_ВидНоменклатури.AfterSelectFunc = null;
            this.directoryControl_ВидНоменклатури.BeforeClickOpenFunc = null;
            this.directoryControl_ВидНоменклатури.BeforeFindFunc = null;
            this.directoryControl_ВидНоменклатури.Bind = null;
            this.directoryControl_ВидНоменклатури.DirectoryPointerItem = null;
            this.directoryControl_ВидНоменклатури.Location = new System.Drawing.Point(132, 131);
            this.directoryControl_ВидНоменклатури.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_ВидНоменклатури.Name = "directoryControl_ВидНоменклатури";
            this.directoryControl_ВидНоменклатури.QueryFind = null;
            this.directoryControl_ВидНоменклатури.SelectForm = null;
            this.directoryControl_ВидНоменклатури.Size = new System.Drawing.Size(468, 27);
            this.directoryControl_ВидНоменклатури.TabIndex = 25;
            // 
            // directoryControl_Виробник
            // 
            this.directoryControl_Виробник.AfterSelectFunc = null;
            this.directoryControl_Виробник.BeforeClickOpenFunc = null;
            this.directoryControl_Виробник.BeforeFindFunc = null;
            this.directoryControl_Виробник.Bind = null;
            this.directoryControl_Виробник.DirectoryPointerItem = null;
            this.directoryControl_Виробник.Location = new System.Drawing.Point(132, 293);
            this.directoryControl_Виробник.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Виробник.Name = "directoryControl_Виробник";
            this.directoryControl_Виробник.QueryFind = null;
            this.directoryControl_Виробник.SelectForm = null;
            this.directoryControl_Виробник.Size = new System.Drawing.Size(301, 27);
            this.directoryControl_Виробник.TabIndex = 23;
            // 
            // textBox_Артикул
            // 
            this.textBox_Артикул.Location = new System.Drawing.Point(132, 200);
            this.textBox_Артикул.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Артикул.Name = "textBox_Артикул";
            this.textBox_Артикул.Size = new System.Drawing.Size(301, 23);
            this.textBox_Артикул.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Артикул:";
            // 
            // textBox_НазваПовна
            // 
            this.textBox_НазваПовна.Location = new System.Drawing.Point(132, 68);
            this.textBox_НазваПовна.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_НазваПовна.Name = "textBox_НазваПовна";
            this.textBox_НазваПовна.Size = new System.Drawing.Size(520, 23);
            this.textBox_НазваПовна.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Повна назва:";
            // 
            // textBox_Опис
            // 
            this.textBox_Опис.Location = new System.Drawing.Point(23, 355);
            this.textBox_Опис.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Опис.Multiline = true;
            this.textBox_Опис.Name = "textBox_Опис";
            this.textBox_Опис.Size = new System.Drawing.Size(629, 206);
            this.textBox_Опис.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Опис:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "Папка:";
            // 
            // directoryControl_НоменклатураПапка
            // 
            this.directoryControl_НоменклатураПапка.AfterSelectFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeClickOpenFunc = null;
            this.directoryControl_НоменклатураПапка.BeforeFindFunc = null;
            this.directoryControl_НоменклатураПапка.Bind = null;
            this.directoryControl_НоменклатураПапка.DirectoryPointerItem = null;
            this.directoryControl_НоменклатураПапка.Location = new System.Drawing.Point(132, 97);
            this.directoryControl_НоменклатураПапка.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_НоменклатураПапка.Name = "directoryControl_НоменклатураПапка";
            this.directoryControl_НоменклатураПапка.QueryFind = null;
            this.directoryControl_НоменклатураПапка.SelectForm = null;
            this.directoryControl_НоменклатураПапка.Size = new System.Drawing.Size(468, 27);
            this.directoryControl_НоменклатураПапка.TabIndex = 53;
            // 
            // pictureBox_ОсновнаКартинка
            // 
            this.pictureBox_ОсновнаКартинка.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ОсновнаКартинка.BackColor = System.Drawing.Color.White;
            this.pictureBox_ОсновнаКартинка.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ОсновнаКартинка.Location = new System.Drawing.Point(663, 37);
            this.pictureBox_ОсновнаКартинка.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox_ОсновнаКартинка.Name = "pictureBox_ОсновнаКартинка";
            this.pictureBox_ОсновнаКартинка.Size = new System.Drawing.Size(403, 575);
            this.pictureBox_ОсновнаКартинка.TabIndex = 55;
            this.pictureBox_ОсновнаКартинка.TabStop = false;
            // 
            // textBox_Код
            // 
            this.textBox_Код.Location = new System.Drawing.Point(132, 229);
            this.textBox_Код.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Код.Name = "textBox_Код";
            this.textBox_Код.Size = new System.Drawing.Size(168, 23);
            this.textBox_Код.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 57;
            this.label11.Text = "Код:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFileInput});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 25);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonFileInput
            // 
            this.toolStripButtonFileInput.Image = global::StorageAndTrade.Properties.Resources.layers;
            this.toolStripButtonFileInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFileInput.Name = "toolStripButtonFileInput";
            this.toolStripButtonFileInput.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonFileInput.Text = "Файли";
            this.toolStripButtonFileInput.Click += new System.EventHandler(this.toolStripButtonFileInput_Click);
            // 
            // buttonOnlySave
            // 
            this.buttonOnlySave.Location = new System.Drawing.Point(167, 576);
            this.buttonOnlySave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOnlySave.Name = "buttonOnlySave";
            this.buttonOnlySave.Size = new System.Drawing.Size(86, 31);
            this.buttonOnlySave.TabIndex = 60;
            this.buttonOnlySave.Text = "Зберегти";
            this.buttonOnlySave.UseVisualStyleBackColor = true;
            this.buttonOnlySave.Click += new System.EventHandler(this.buttonOnlySave_Click);
            // 
            // Form_НоменклатураЕлемент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 617);
            this.Controls.Add(this.buttonOnlySave);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_Код);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox_ОсновнаКартинка);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.directoryControl_НоменклатураПапка);
            this.Controls.Add(this.textBox_Опис);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_НазваПовна);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Артикул);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_ТипНоменклатури);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directoryControl_ОдиницяВиміру);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.directoryControl_ВидНоменклатури);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryControl_Виробник);
            this.Controls.Add(this.textBox_Назва);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_НоменклатураЕлемент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Номенклатура елемент";
            this.Load += new System.EventHandler(this.Form_НоменклатураЕлемент_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ОсновнаКартинка)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox_Назва;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DirectoryControl directoryControl_Виробник;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_ВидНоменклатури;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_ОдиницяВиміру;
        private System.Windows.Forms.ComboBox comboBox_ТипНоменклатури;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Артикул;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_НазваПовна;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Опис;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DirectoryControl directoryControl_НоменклатураПапка;
        private System.Windows.Forms.PictureBox pictureBox_ОсновнаКартинка;
        private System.Windows.Forms.TextBox textBox_Код;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFileInput;
        private System.Windows.Forms.Button buttonOnlySave;
    }
}