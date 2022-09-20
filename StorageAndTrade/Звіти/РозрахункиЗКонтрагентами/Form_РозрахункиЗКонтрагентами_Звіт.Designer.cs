
namespace StorageAndTrade
{
    partial class Form_РозрахункиЗКонтрагентами_Звіт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_РозрахункиЗКонтрагентами_Звіт));
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.directoryControl_Валюти = new StorageAndTrade.DirectoryControl();
            this.directoryControl_Контрагенти = new StorageAndTrade.DirectoryControl();
            this.directoryControl_КонтрагентиПапка = new StorageAndTrade.DirectoryControl();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Documents = new System.Windows.Forms.Button();
            this.buttonOstatokAndOborot = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(394, 12);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(229, 23);
            this.dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Період з";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.Location = new System.Drawing.Point(657, 12);
            this.dateTimeStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(229, 23);
            this.dateTimeStop.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(9, 145);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(105, 31);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Залишки";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Папка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Контрагенти:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Валюта:";
            // 
            // directoryControl_Валюти
            // 
            this.directoryControl_Валюти.AfterSelectFunc = null;
            this.directoryControl_Валюти.BeforeClickOpenFunc = null;
            this.directoryControl_Валюти.BeforeFindFunc = null;
            this.directoryControl_Валюти.Bind = null;
            this.directoryControl_Валюти.DirectoryPointerItem = null;
            this.directoryControl_Валюти.Location = new System.Drawing.Point(672, 69);
            this.directoryControl_Валюти.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Валюти.Name = "directoryControl_Валюти";
            this.directoryControl_Валюти.QueryFind = null;
            this.directoryControl_Валюти.SelectForm = null;
            this.directoryControl_Валюти.Size = new System.Drawing.Size(342, 27);
            this.directoryControl_Валюти.TabIndex = 61;
            // 
            // directoryControl_Контрагенти
            // 
            this.directoryControl_Контрагенти.AfterSelectFunc = null;
            this.directoryControl_Контрагенти.BeforeClickOpenFunc = null;
            this.directoryControl_Контрагенти.BeforeFindFunc = null;
            this.directoryControl_Контрагенти.Bind = null;
            this.directoryControl_Контрагенти.DirectoryPointerItem = null;
            this.directoryControl_Контрагенти.Location = new System.Drawing.Point(100, 54);
            this.directoryControl_Контрагенти.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_Контрагенти.Name = "directoryControl_Контрагенти";
            this.directoryControl_Контрагенти.QueryFind = null;
            this.directoryControl_Контрагенти.SelectForm = null;
            this.directoryControl_Контрагенти.Size = new System.Drawing.Size(469, 27);
            this.directoryControl_Контрагенти.TabIndex = 57;
            // 
            // directoryControl_КонтрагентиПапка
            // 
            this.directoryControl_КонтрагентиПапка.AfterSelectFunc = null;
            this.directoryControl_КонтрагентиПапка.BeforeClickOpenFunc = null;
            this.directoryControl_КонтрагентиПапка.BeforeFindFunc = null;
            this.directoryControl_КонтрагентиПапка.Bind = null;
            this.directoryControl_КонтрагентиПапка.DirectoryPointerItem = null;
            this.directoryControl_КонтрагентиПапка.Location = new System.Drawing.Point(100, 22);
            this.directoryControl_КонтрагентиПапка.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.directoryControl_КонтрагентиПапка.Name = "directoryControl_КонтрагентиПапка";
            this.directoryControl_КонтрагентиПапка.QueryFind = null;
            this.directoryControl_КонтрагентиПапка.SelectForm = null;
            this.directoryControl_КонтрагентиПапка.Size = new System.Drawing.Size(469, 27);
            this.directoryControl_КонтрагентиПапка.TabIndex = 55;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(909, 145);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 31);
            this.buttonClose.TabIndex = 71;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.directoryControl_Контрагенти);
            this.groupBox1.Controls.Add(this.directoryControl_КонтрагентиПапка);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(587, 92);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контрагент";
            // 
            // button_Documents
            // 
            this.button_Documents.Location = new System.Drawing.Point(316, 145);
            this.button_Documents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.Size = new System.Drawing.Size(112, 31);
            this.button_Documents.TabIndex = 79;
            this.button_Documents.Text = "По документах";
            this.button_Documents.UseVisualStyleBackColor = true;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // buttonOstatokAndOborot
            // 
            this.buttonOstatokAndOborot.Location = new System.Drawing.Point(121, 145);
            this.buttonOstatokAndOborot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOstatokAndOborot.Name = "buttonOstatokAndOborot";
            this.buttonOstatokAndOborot.Size = new System.Drawing.Size(188, 31);
            this.buttonOstatokAndOborot.TabIndex = 80;
            this.buttonOstatokAndOborot.Text = "Залишки та обороти";
            this.buttonOstatokAndOborot.UseVisualStyleBackColor = true;
            this.buttonOstatokAndOborot.Click += new System.EventHandler(this.buttonOstatokAndOborot_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 25);
            this.label8.TabIndex = 86;
            this.label8.Text = "Розрахунки з контрагентами";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.label8);
            this.splitContainer.Panel1.Controls.Add(this.dateTimeStart);
            this.splitContainer.Panel1.Controls.Add(this.buttonOstatokAndOborot);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.button_Documents);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.buttonCreate);
            this.splitContainer.Panel1.Controls.Add(this.buttonClose);
            this.splitContainer.Panel1.Controls.Add(this.dateTimeStop);
            this.splitContainer.Panel1.Controls.Add(this.label5);
            this.splitContainer.Panel1.Controls.Add(this.directoryControl_Валюти);
            this.splitContainer.Size = new System.Drawing.Size(1031, 541);
            this.splitContainer.SplitterDistance = 187;
            this.splitContainer.TabIndex = 87;
            // 
            // Form_РозрахункиЗКонтрагентами_Звіт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 541);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_РозрахункиЗКонтрагентами_Звіт";
            this.Text = "Звіт \"Розрахунки з контрагентами\"";
            this.Load += new System.EventHandler(this.Form_РозрахункиЗКонтрагентами_Звіт_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label9;
        private DirectoryControl directoryControl_КонтрагентиПапка;
        private System.Windows.Forms.Label label3;
        private DirectoryControl directoryControl_Контрагенти;
        private System.Windows.Forms.Label label5;
        private DirectoryControl directoryControl_Валюти;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Documents;
        private System.Windows.Forms.Button buttonOstatokAndOborot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}