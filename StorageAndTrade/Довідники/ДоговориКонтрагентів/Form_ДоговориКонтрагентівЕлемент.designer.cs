
namespace StorageAndTrade
{
    partial class Form_ДоговориКонтрагентівЕлемент
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ДоговориКонтрагентівЕлемент));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Статус = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_ГосподарськаОперація = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.directoryControl_Контрагент = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Підрозділ = new StorageAndTrade.DirectoryControl();
            this.directoryControl_БанківськийРахунокКонтрагента = new StorageAndTrade.DirectoryControl();
            this.directoryControl_БанківськийРахунок = new StorageAndTrade.DirectoryControl();
            this.comboBox_ТипДоговору = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Код = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(364, 323);
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
            this.buttonSave.Location = new System.Drawing.Point(12, 323);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 14);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(513, 23);
            this.textBoxName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Назва:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Рахунок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Рахунок контрагента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Підрозділ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Контрагент:";
            // 
            // comboBox_Статус
            // 
            this.comboBox_Статус.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Статус.FormattingEnabled = true;
            this.comboBox_Статус.Location = new System.Drawing.Point(85, 10);
            this.comboBox_Статус.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Статус.Name = "comboBox_Статус";
            this.comboBox_Статус.Size = new System.Drawing.Size(172, 23);
            this.comboBox_Статус.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Статус:";
            // 
            // comboBox_ГосподарськаОперація
            // 
            this.comboBox_ГосподарськаОперація.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ГосподарськаОперація.FormattingEnabled = true;
            this.comboBox_ГосподарськаОперація.Location = new System.Drawing.Point(85, 41);
            this.comboBox_ГосподарськаОперація.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ГосподарськаОперація.Name = "comboBox_ГосподарськаОперація";
            this.comboBox_ГосподарськаОперація.Size = new System.Drawing.Size(289, 23);
            this.comboBox_ГосподарськаОперація.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Операція:";
            // 
            // directoryControl_Контрагент
            // 
            this.directoryControl_Контрагент.AfterSelectFunc = null;
            this.directoryControl_Контрагент.BeforeClickOpenFunc = null;
            this.directoryControl_Контрагент.BeforeFindFunc = null;
            this.directoryControl_Контрагент.Bind = null;
            this.directoryControl_Контрагент.DirectoryPointerItem = null;
            this.directoryControl_Контрагент.Location = new System.Drawing.Point(105, 44);
            this.directoryControl_Контрагент.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Контрагент.Name = "directoryControl_Контрагент";
            this.directoryControl_Контрагент.QueryFind = null;
            this.directoryControl_Контрагент.SelectForm = null;
            this.directoryControl_Контрагент.Size = new System.Drawing.Size(511, 27);
            this.directoryControl_Контрагент.TabIndex = 41;
            // 
            // directoryControl_Підрозділ
            // 
            this.directoryControl_Підрозділ.AfterSelectFunc = null;
            this.directoryControl_Підрозділ.BeforeClickOpenFunc = null;
            this.directoryControl_Підрозділ.BeforeFindFunc = null;
            this.directoryControl_Підрозділ.Bind = null;
            this.directoryControl_Підрозділ.DirectoryPointerItem = null;
            this.directoryControl_Підрозділ.Location = new System.Drawing.Point(85, 70);
            this.directoryControl_Підрозділ.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Підрозділ.Name = "directoryControl_Підрозділ";
            this.directoryControl_Підрозділ.QueryFind = null;
            this.directoryControl_Підрозділ.SelectForm = null;
            this.directoryControl_Підрозділ.Size = new System.Drawing.Size(291, 27);
            this.directoryControl_Підрозділ.TabIndex = 39;
            // 
            // directoryControl_БанківськийРахунокКонтрагента
            // 
            this.directoryControl_БанківськийРахунокКонтрагента.AfterSelectFunc = null;
            this.directoryControl_БанківськийРахунокКонтрагента.BeforeClickOpenFunc = null;
            this.directoryControl_БанківськийРахунокКонтрагента.BeforeFindFunc = null;
            this.directoryControl_БанківськийРахунокКонтрагента.Bind = null;
            this.directoryControl_БанківськийРахунокКонтрагента.DirectoryPointerItem = null;
            this.directoryControl_БанківськийРахунокКонтрагента.Location = new System.Drawing.Point(145, 47);
            this.directoryControl_БанківськийРахунокКонтрагента.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_БанківськийРахунокКонтрагента.Name = "directoryControl_БанківськийРахунокКонтрагента";
            this.directoryControl_БанківськийРахунокКонтрагента.QueryFind = null;
            this.directoryControl_БанківськийРахунокКонтрагента.SelectForm = null;
            this.directoryControl_БанківськийРахунокКонтрагента.Size = new System.Drawing.Size(343, 27);
            this.directoryControl_БанківськийРахунокКонтрагента.TabIndex = 37;
            // 
            // directoryControl_БанківськийРахунок
            // 
            this.directoryControl_БанківськийРахунок.AfterSelectFunc = null;
            this.directoryControl_БанківськийРахунок.BeforeClickOpenFunc = null;
            this.directoryControl_БанківськийРахунок.BeforeFindFunc = null;
            this.directoryControl_БанківськийРахунок.Bind = null;
            this.directoryControl_БанківськийРахунок.DirectoryPointerItem = null;
            this.directoryControl_БанківськийРахунок.Location = new System.Drawing.Point(145, 14);
            this.directoryControl_БанківськийРахунок.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_БанківськийРахунок.Name = "directoryControl_БанківськийРахунок";
            this.directoryControl_БанківськийРахунок.QueryFind = null;
            this.directoryControl_БанківськийРахунок.SelectForm = null;
            this.directoryControl_БанківськийРахунок.Size = new System.Drawing.Size(343, 27);
            this.directoryControl_БанківськийРахунок.TabIndex = 35;
            // 
            // comboBox_ТипДоговору
            // 
            this.comboBox_ТипДоговору.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ТипДоговору.Location = new System.Drawing.Point(105, 78);
            this.comboBox_ТипДоговору.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ТипДоговору.Name = "comboBox_ТипДоговору";
            this.comboBox_ТипДоговору.Size = new System.Drawing.Size(299, 23);
            this.comboBox_ТипДоговору.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Тип договору:";
            // 
            // textBox_Код
            // 
            this.textBox_Код.Location = new System.Drawing.Point(665, 14);
            this.textBox_Код.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Код.Name = "textBox_Код";
            this.textBox_Код.Size = new System.Drawing.Size(129, 23);
            this.textBox_Код.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "Код:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 190);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.directoryControl_БанківськийРахунок);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.directoryControl_БанківськийРахунокКонтрагента);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Банківські рахунки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.directoryControl_Підрозділ);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox_Статус);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox_ГосподарськаОперація);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додатково";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form_ДоговориКонтрагентівЕлемент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 366);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox_Код);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_ТипДоговору);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.directoryControl_Контрагент);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ДоговориКонтрагентівЕлемент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договори контрагентів";
            this.Load += new System.EventHandler(this.Form_ДоговориКонтрагентівЕлемент_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DirectoryControl directoryControl_БанківськийРахунок;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_БанківськийРахунокКонтрагента;
        private System.Windows.Forms.Label label4;
        private DirectoryControl directoryControl_Підрозділ;
        private System.Windows.Forms.Label label5;
        private DirectoryControl directoryControl_Контрагент;
        private System.Windows.Forms.ComboBox comboBox_Статус;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_ГосподарськаОперація;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_ТипДоговору;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Код;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}