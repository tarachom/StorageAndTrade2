
namespace StorageAndTrade
{
    partial class FormDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesktop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownLoadXml = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEndDownload = new System.Windows.Forms.Label();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel_Валюти = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel_ЗамовленняПостачальнику = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ПоступленняТоварівТаПослуг = new System.Windows.Forms.LinkLabel();
            this.linkLabel_РозхіднийКасовийОрдер = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel_ПрихіднийКасовийОрдер = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel_АктВиконанихРобіт = new System.Windows.Forms.LinkLabel();
            this.linkLabel_РахунокФактура = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ВстановленняЦінНоменклатури = new System.Windows.Forms.LinkLabel();
            this.linkLabel_РеалізаціяТоварівТаПослуг = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ЗамовленняКлієнта = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ВільніЗалишки = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ПартіїТоварів = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ТовариНаСкладах = new System.Windows.Forms.LinkLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel_ПереміщенняТоварів = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ПсуванняТоварів = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ВнутрішнєСпоживанняТоварів = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ВведенняЗалишків = new System.Windows.Forms.LinkLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabel_ЗамовленняПостачальникам = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ЗамовленняКлієнтів = new System.Windows.Forms.LinkLabel();
            this.linkLabel_РухКоштів = new System.Windows.Forms.LinkLabel();
            this.linkLabel_РозрахункиЗКонтрагентами = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DownLoadXml);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelEndDownload);
            this.panel1.Controls.Add(this.dataGridViewRecords);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 295);
            this.panel1.TabIndex = 0;
            // 
            // DownLoadXml
            // 
            this.DownLoadXml.Location = new System.Drawing.Point(308, -1);
            this.DownLoadXml.Name = "DownLoadXml";
            this.DownLoadXml.Size = new System.Drawing.Size(75, 23);
            this.DownLoadXml.TabIndex = 2;
            this.DownLoadXml.Text = "Обновити";
            this.DownLoadXml.UseVisualStyleBackColor = true;
            this.DownLoadXml.Click += new System.EventHandler(this.DownLoadXml_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Історія завантажень:";
            // 
            // labelEndDownload
            // 
            this.labelEndDownload.AutoSize = true;
            this.labelEndDownload.Location = new System.Drawing.Point(145, 3);
            this.labelEndDownload.Name = "labelEndDownload";
            this.labelEndDownload.Size = new System.Drawing.Size(16, 15);
            this.labelEndDownload.TabIndex = 2;
            this.labelEndDownload.Text = "...";
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Location = new System.Drawing.Point(4, 54);
            this.dataGridViewRecords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecords.Size = new System.Drawing.Size(378, 238);
            this.dataGridViewRecords.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Останнє завантаження:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel_Валюти);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Завантаження курсу валют НБУ";
            // 
            // linkLabel_Валюти
            // 
            this.linkLabel_Валюти.AutoSize = true;
            this.linkLabel_Валюти.Location = new System.Drawing.Point(7, 24);
            this.linkLabel_Валюти.Name = "linkLabel_Валюти";
            this.linkLabel_Валюти.Size = new System.Drawing.Size(102, 15);
            this.linkLabel_Валюти.TabIndex = 1;
            this.linkLabel_Валюти.TabStop = true;
            this.linkLabel_Валюти.Text = "Довідник Валюти";
            this.linkLabel_Валюти.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Валюти_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel_ЗамовленняПостачальнику);
            this.groupBox2.Controls.Add(this.linkLabel_ПоступленняТоварівТаПослуг);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Закупки";
            // 
            // linkLabel_ЗамовленняПостачальнику
            // 
            this.linkLabel_ЗамовленняПостачальнику.AutoSize = true;
            this.linkLabel_ЗамовленняПостачальнику.Location = new System.Drawing.Point(17, 27);
            this.linkLabel_ЗамовленняПостачальнику.Name = "linkLabel_ЗамовленняПостачальнику";
            this.linkLabel_ЗамовленняПостачальнику.Size = new System.Drawing.Size(161, 15);
            this.linkLabel_ЗамовленняПостачальнику.TabIndex = 3;
            this.linkLabel_ЗамовленняПостачальнику.TabStop = true;
            this.linkLabel_ЗамовленняПостачальнику.Text = "Замовлення постачальнику";
            this.linkLabel_ЗамовленняПостачальнику.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ЗамовленняПостачальнику_LinkClicked);
            // 
            // linkLabel_ПоступленняТоварівТаПослуг
            // 
            this.linkLabel_ПоступленняТоварівТаПослуг.AutoSize = true;
            this.linkLabel_ПоступленняТоварівТаПослуг.Location = new System.Drawing.Point(17, 53);
            this.linkLabel_ПоступленняТоварівТаПослуг.Name = "linkLabel_ПоступленняТоварівТаПослуг";
            this.linkLabel_ПоступленняТоварівТаПослуг.Size = new System.Drawing.Size(178, 15);
            this.linkLabel_ПоступленняТоварівТаПослуг.TabIndex = 2;
            this.linkLabel_ПоступленняТоварівТаПослуг.TabStop = true;
            this.linkLabel_ПоступленняТоварівТаПослуг.Text = "Поступлення товарів та послуг";
            this.linkLabel_ПоступленняТоварівТаПослуг.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ПоступленняТоварівТаПослуг_LinkClicked);
            // 
            // linkLabel_РозхіднийКасовийОрдер
            // 
            this.linkLabel_РозхіднийКасовийОрдер.AutoSize = true;
            this.linkLabel_РозхіднийКасовийОрдер.Location = new System.Drawing.Point(17, 51);
            this.linkLabel_РозхіднийКасовийОрдер.Name = "linkLabel_РозхіднийКасовийОрдер";
            this.linkLabel_РозхіднийКасовийОрдер.Size = new System.Drawing.Size(146, 15);
            this.linkLabel_РозхіднийКасовийОрдер.TabIndex = 2;
            this.linkLabel_РозхіднийКасовийОрдер.TabStop = true;
            this.linkLabel_РозхіднийКасовийОрдер.Text = "Розхідний касовий ордер";
            this.linkLabel_РозхіднийКасовийОрдер.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_РозхіднийКасовийОрдер_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel_ПрихіднийКасовийОрдер);
            this.groupBox3.Controls.Add(this.linkLabel_РозхіднийКасовийОрдер);
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Каса";
            // 
            // linkLabel_ПрихіднийКасовийОрдер
            // 
            this.linkLabel_ПрихіднийКасовийОрдер.AutoSize = true;
            this.linkLabel_ПрихіднийКасовийОрдер.Location = new System.Drawing.Point(17, 25);
            this.linkLabel_ПрихіднийКасовийОрдер.Name = "linkLabel_ПрихіднийКасовийОрдер";
            this.linkLabel_ПрихіднийКасовийОрдер.Size = new System.Drawing.Size(150, 15);
            this.linkLabel_ПрихіднийКасовийОрдер.TabIndex = 3;
            this.linkLabel_ПрихіднийКасовийОрдер.TabStop = true;
            this.linkLabel_ПрихіднийКасовийОрдер.Text = "Прихідний касовий ордер";
            this.linkLabel_ПрихіднийКасовийОрдер.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ПрихіднийКасовийОрдер_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel_АктВиконанихРобіт);
            this.groupBox4.Controls.Add(this.linkLabel_РахунокФактура);
            this.groupBox4.Controls.Add(this.linkLabel_ВстановленняЦінНоменклатури);
            this.groupBox4.Controls.Add(this.linkLabel_РеалізаціяТоварівТаПослуг);
            this.groupBox4.Controls.Add(this.linkLabel_ЗамовленняКлієнта);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Продажі";
            // 
            // linkLabel_АктВиконанихРобіт
            // 
            this.linkLabel_АктВиконанихРобіт.AutoSize = true;
            this.linkLabel_АктВиконанихРобіт.Location = new System.Drawing.Point(17, 79);
            this.linkLabel_АктВиконанихРобіт.Name = "linkLabel_АктВиконанихРобіт";
            this.linkLabel_АктВиконанихРобіт.Size = new System.Drawing.Size(120, 15);
            this.linkLabel_АктВиконанихРобіт.TabIndex = 5;
            this.linkLabel_АктВиконанихРобіт.TabStop = true;
            this.linkLabel_АктВиконанихРобіт.Text = "Акт виконаних робіт";
            this.linkLabel_АктВиконанихРобіт.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_АктВиконанихРобіт_LinkClicked);
            // 
            // linkLabel_РахунокФактура
            // 
            this.linkLabel_РахунокФактура.AutoSize = true;
            this.linkLabel_РахунокФактура.Location = new System.Drawing.Point(17, 52);
            this.linkLabel_РахунокФактура.Name = "linkLabel_РахунокФактура";
            this.linkLabel_РахунокФактура.Size = new System.Drawing.Size(100, 15);
            this.linkLabel_РахунокФактура.TabIndex = 4;
            this.linkLabel_РахунокФактура.TabStop = true;
            this.linkLabel_РахунокФактура.Text = "Рахунок фактура";
            this.linkLabel_РахунокФактура.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_РахунокФактура_LinkClicked);
            // 
            // linkLabel_ВстановленняЦінНоменклатури
            // 
            this.linkLabel_ВстановленняЦінНоменклатури.AutoSize = true;
            this.linkLabel_ВстановленняЦінНоменклатури.Location = new System.Drawing.Point(17, 133);
            this.linkLabel_ВстановленняЦінНоменклатури.Name = "linkLabel_ВстановленняЦінНоменклатури";
            this.linkLabel_ВстановленняЦінНоменклатури.Size = new System.Drawing.Size(187, 15);
            this.linkLabel_ВстановленняЦінНоменклатури.TabIndex = 3;
            this.linkLabel_ВстановленняЦінНоменклатури.TabStop = true;
            this.linkLabel_ВстановленняЦінНоменклатури.Text = "Встановлення цін номенклатури";
            this.linkLabel_ВстановленняЦінНоменклатури.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ВстановленняЦінНоменклатури_LinkClicked);
            // 
            // linkLabel_РеалізаціяТоварівТаПослуг
            // 
            this.linkLabel_РеалізаціяТоварівТаПослуг.AutoSize = true;
            this.linkLabel_РеалізаціяТоварівТаПослуг.Location = new System.Drawing.Point(17, 107);
            this.linkLabel_РеалізаціяТоварівТаПослуг.Name = "linkLabel_РеалізаціяТоварівТаПослуг";
            this.linkLabel_РеалізаціяТоварівТаПослуг.Size = new System.Drawing.Size(161, 15);
            this.linkLabel_РеалізаціяТоварівТаПослуг.TabIndex = 3;
            this.linkLabel_РеалізаціяТоварівТаПослуг.TabStop = true;
            this.linkLabel_РеалізаціяТоварівТаПослуг.Text = "Реалізація товарів та послуг";
            this.linkLabel_РеалізаціяТоварівТаПослуг.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_РеалізаціяТоварівТаПослуг_LinkClicked);
            // 
            // linkLabel_ЗамовленняКлієнта
            // 
            this.linkLabel_ЗамовленняКлієнта.AutoSize = true;
            this.linkLabel_ЗамовленняКлієнта.Location = new System.Drawing.Point(17, 26);
            this.linkLabel_ЗамовленняКлієнта.Name = "linkLabel_ЗамовленняКлієнта";
            this.linkLabel_ЗамовленняКлієнта.Size = new System.Drawing.Size(118, 15);
            this.linkLabel_ЗамовленняКлієнта.TabIndex = 2;
            this.linkLabel_ЗамовленняКлієнта.TabStop = true;
            this.linkLabel_ЗамовленняКлієнта.Text = "Замовлення клієнта";
            this.linkLabel_ЗамовленняКлієнта.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ЗамовленняКлієнта_LinkClicked);
            // 
            // linkLabel_ВільніЗалишки
            // 
            this.linkLabel_ВільніЗалишки.AutoSize = true;
            this.linkLabel_ВільніЗалишки.Location = new System.Drawing.Point(17, 133);
            this.linkLabel_ВільніЗалишки.Name = "linkLabel_ВільніЗалишки";
            this.linkLabel_ВільніЗалишки.Size = new System.Drawing.Size(92, 15);
            this.linkLabel_ВільніЗалишки.TabIndex = 9;
            this.linkLabel_ВільніЗалишки.TabStop = true;
            this.linkLabel_ВільніЗалишки.Text = "Вільні залишки";
            this.linkLabel_ВільніЗалишки.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ВільніЗалишки_LinkClicked);
            // 
            // linkLabel_ПартіїТоварів
            // 
            this.linkLabel_ПартіїТоварів.AutoSize = true;
            this.linkLabel_ПартіїТоварів.Location = new System.Drawing.Point(17, 107);
            this.linkLabel_ПартіїТоварів.Name = "linkLabel_ПартіїТоварів";
            this.linkLabel_ПартіїТоварів.Size = new System.Drawing.Size(83, 15);
            this.linkLabel_ПартіїТоварів.TabIndex = 8;
            this.linkLabel_ПартіїТоварів.TabStop = true;
            this.linkLabel_ПартіїТоварів.Text = "Партії товарів";
            this.linkLabel_ПартіїТоварів.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ПартіїТоварів_LinkClicked);
            // 
            // linkLabel_ТовариНаСкладах
            // 
            this.linkLabel_ТовариНаСкладах.AutoSize = true;
            this.linkLabel_ТовариНаСкладах.Location = new System.Drawing.Point(17, 79);
            this.linkLabel_ТовариНаСкладах.Name = "linkLabel_ТовариНаСкладах";
            this.linkLabel_ТовариНаСкладах.Size = new System.Drawing.Size(108, 15);
            this.linkLabel_ТовариНаСкладах.TabIndex = 6;
            this.linkLabel_ТовариНаСкладах.TabStop = true;
            this.linkLabel_ТовариНаСкладах.Text = "Товари на складах";
            this.linkLabel_ТовариНаСкладах.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ТовариНаСкладах_LinkClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel_ПереміщенняТоварів);
            this.groupBox5.Controls.Add(this.linkLabel_ПсуванняТоварів);
            this.groupBox5.Controls.Add(this.linkLabel_ВнутрішнєСпоживанняТоварів);
            this.groupBox5.Controls.Add(this.linkLabel_ВведенняЗалишків);
            this.groupBox5.Location = new System.Drawing.Point(12, 360);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 137);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Склад";
            // 
            // linkLabel_ПереміщенняТоварів
            // 
            this.linkLabel_ПереміщенняТоварів.AutoSize = true;
            this.linkLabel_ПереміщенняТоварів.Location = new System.Drawing.Point(17, 25);
            this.linkLabel_ПереміщенняТоварів.Name = "linkLabel_ПереміщенняТоварів";
            this.linkLabel_ПереміщенняТоварів.Size = new System.Drawing.Size(207, 15);
            this.linkLabel_ПереміщенняТоварів.TabIndex = 3;
            this.linkLabel_ПереміщенняТоварів.TabStop = true;
            this.linkLabel_ПереміщенняТоварів.Text = "Переміщення товарів між складами";
            this.linkLabel_ПереміщенняТоварів.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ПереміщенняТоварів_LinkClicked);
            // 
            // linkLabel_ПсуванняТоварів
            // 
            this.linkLabel_ПсуванняТоварів.AutoSize = true;
            this.linkLabel_ПсуванняТоварів.Location = new System.Drawing.Point(17, 104);
            this.linkLabel_ПсуванняТоварів.Name = "linkLabel_ПсуванняТоварів";
            this.linkLabel_ПсуванняТоварів.Size = new System.Drawing.Size(103, 15);
            this.linkLabel_ПсуванняТоварів.TabIndex = 2;
            this.linkLabel_ПсуванняТоварів.TabStop = true;
            this.linkLabel_ПсуванняТоварів.Text = "Псування товарів";
            this.linkLabel_ПсуванняТоварів.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ПсуванняТоварів_LinkClicked);
            // 
            // linkLabel_ВнутрішнєСпоживанняТоварів
            // 
            this.linkLabel_ВнутрішнєСпоживанняТоварів.AutoSize = true;
            this.linkLabel_ВнутрішнєСпоживанняТоварів.Location = new System.Drawing.Point(17, 77);
            this.linkLabel_ВнутрішнєСпоживанняТоварів.Name = "linkLabel_ВнутрішнєСпоживанняТоварів";
            this.linkLabel_ВнутрішнєСпоживанняТоварів.Size = new System.Drawing.Size(180, 15);
            this.linkLabel_ВнутрішнєСпоживанняТоварів.TabIndex = 2;
            this.linkLabel_ВнутрішнєСпоживанняТоварів.TabStop = true;
            this.linkLabel_ВнутрішнєСпоживанняТоварів.Text = "Внутрішнє cпоживання товарів";
            this.linkLabel_ВнутрішнєСпоживанняТоварів.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ВнутрішнєСпоживанняТоварів_LinkClicked);
            // 
            // linkLabel_ВведенняЗалишків
            // 
            this.linkLabel_ВведенняЗалишків.AutoSize = true;
            this.linkLabel_ВведенняЗалишків.Location = new System.Drawing.Point(17, 51);
            this.linkLabel_ВведенняЗалишків.Name = "linkLabel_ВведенняЗалишків";
            this.linkLabel_ВведенняЗалишків.Size = new System.Drawing.Size(112, 15);
            this.linkLabel_ВведенняЗалишків.TabIndex = 2;
            this.linkLabel_ВведенняЗалишків.TabStop = true;
            this.linkLabel_ВведенняЗалишків.Text = "Введення залишків";
            this.linkLabel_ВведенняЗалишків.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ВведенняЗалишків_LinkClicked);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.linkLabel_ЗамовленняПостачальникам);
            this.groupBox6.Controls.Add(this.linkLabel_ЗамовленняКлієнтів);
            this.groupBox6.Controls.Add(this.linkLabel_РухКоштів);
            this.groupBox6.Controls.Add(this.linkLabel_РозрахункиЗКонтрагентами);
            this.groupBox6.Controls.Add(this.linkLabel_ВільніЗалишки);
            this.groupBox6.Controls.Add(this.linkLabel_ТовариНаСкладах);
            this.groupBox6.Controls.Add(this.linkLabel_ПартіїТоварів);
            this.groupBox6.Location = new System.Drawing.Point(259, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 215);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Звіти";
            // 
            // linkLabel_ЗамовленняПостачальникам
            // 
            this.linkLabel_ЗамовленняПостачальникам.AutoSize = true;
            this.linkLabel_ЗамовленняПостачальникам.Location = new System.Drawing.Point(17, 52);
            this.linkLabel_ЗамовленняПостачальникам.Name = "linkLabel_ЗамовленняПостачальникам";
            this.linkLabel_ЗамовленняПостачальникам.Size = new System.Drawing.Size(170, 15);
            this.linkLabel_ЗамовленняПостачальникам.TabIndex = 9;
            this.linkLabel_ЗамовленняПостачальникам.TabStop = true;
            this.linkLabel_ЗамовленняПостачальникам.Text = "Замовлення постачальникам";
            this.linkLabel_ЗамовленняПостачальникам.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ЗамовленняПостачальникам_LinkClicked);
            // 
            // linkLabel_ЗамовленняКлієнтів
            // 
            this.linkLabel_ЗамовленняКлієнтів.AutoSize = true;
            this.linkLabel_ЗамовленняКлієнтів.Location = new System.Drawing.Point(17, 26);
            this.linkLabel_ЗамовленняКлієнтів.Name = "linkLabel_ЗамовленняКлієнтів";
            this.linkLabel_ЗамовленняКлієнтів.Size = new System.Drawing.Size(121, 15);
            this.linkLabel_ЗамовленняКлієнтів.TabIndex = 9;
            this.linkLabel_ЗамовленняКлієнтів.TabStop = true;
            this.linkLabel_ЗамовленняКлієнтів.Text = "Замовлення клієнтів";
            this.linkLabel_ЗамовленняКлієнтів.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ЗамовленняКлієнтів_LinkClicked);
            // 
            // linkLabel_РухКоштів
            // 
            this.linkLabel_РухКоштів.AutoSize = true;
            this.linkLabel_РухКоштів.Location = new System.Drawing.Point(17, 184);
            this.linkLabel_РухКоштів.Name = "linkLabel_РухКоштів";
            this.linkLabel_РухКоштів.Size = new System.Drawing.Size(67, 15);
            this.linkLabel_РухКоштів.TabIndex = 9;
            this.linkLabel_РухКоштів.TabStop = true;
            this.linkLabel_РухКоштів.Text = "Рух коштів";
            this.linkLabel_РухКоштів.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_РухКоштів_LinkClicked);
            // 
            // linkLabel_РозрахункиЗКонтрагентами
            // 
            this.linkLabel_РозрахункиЗКонтрагентами.AutoSize = true;
            this.linkLabel_РозрахункиЗКонтрагентами.Location = new System.Drawing.Point(17, 159);
            this.linkLabel_РозрахункиЗКонтрагентами.Name = "linkLabel_РозрахункиЗКонтрагентами";
            this.linkLabel_РозрахункиЗКонтрагентами.Size = new System.Drawing.Size(165, 15);
            this.linkLabel_РозрахункиЗКонтрагентами.TabIndex = 9;
            this.linkLabel_РозрахункиЗКонтрагентами.TabStop = true;
            this.linkLabel_РозрахункиЗКонтрагентами.Text = "Розрахунки з контрагентами";
            this.linkLabel_РозрахункиЗКонтрагентами.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_РозрахункиЗКонтрагентами_LinkClicked);
            // 
            // FormDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робочий стіл";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDesktop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEndDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DownLoadXml;
        private System.Windows.Forms.LinkLabel linkLabel_Валюти;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel_РозхіднийКасовийОрдер;
        private System.Windows.Forms.LinkLabel linkLabel_ЗамовленняПостачальнику;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel_ПрихіднийКасовийОрдер;
        private System.Windows.Forms.LinkLabel linkLabel_ПоступленняТоварівТаПослуг;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel_РеалізаціяТоварівТаПослуг;
        private System.Windows.Forms.LinkLabel linkLabel_ЗамовленняКлієнта;
        private System.Windows.Forms.LinkLabel linkLabel_РахунокФактура;
        private System.Windows.Forms.LinkLabel linkLabel_АктВиконанихРобіт;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel_ПереміщенняТоварів;
        private System.Windows.Forms.LinkLabel linkLabel_ВведенняЗалишків;
        private System.Windows.Forms.LinkLabel linkLabel_ВнутрішнєСпоживанняТоварів;
        private System.Windows.Forms.LinkLabel linkLabel_ПсуванняТоварів;
        private System.Windows.Forms.LinkLabel linkLabel_ВстановленняЦінНоменклатури;
        private System.Windows.Forms.LinkLabel linkLabel_ТовариНаСкладах;
        private System.Windows.Forms.LinkLabel linkLabel_ПартіїТоварів;
        private System.Windows.Forms.LinkLabel linkLabel_ВільніЗалишки;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel linkLabel_ЗамовленняПостачальникам;
        private System.Windows.Forms.LinkLabel linkLabel_ЗамовленняКлієнтів;
        private System.Windows.Forms.LinkLabel linkLabel_РозрахункиЗКонтрагентами;
        private System.Windows.Forms.LinkLabel linkLabel_РухКоштів;
    }
}