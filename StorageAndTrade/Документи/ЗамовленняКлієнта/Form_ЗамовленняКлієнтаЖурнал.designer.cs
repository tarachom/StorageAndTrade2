﻿
namespace StorageAndTrade
{
    partial class Form_ЗамовленняКлієнтаЖурнал
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ЗамовленняКлієнтаЖурнал));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonДрукПроводок = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearSpend = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSpend = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton_ВвестиНаОснові = new System.Windows.Forms.ToolStripDropDownButton();
            this.реалізаціяТоварівТаПослугtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняПостачальникуtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступленняТоварівТаПослугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сomboBox_ТипПеріоду = new System.Windows.Forms.ToolStripComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 33);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonRefresh,
            this.toolStripButtonCopy,
            this.toolStripButtonDelete,
            this.toolStripButtonДрукПроводок,
            this.toolStripButtonClearSpend,
            this.toolStripButtonSpend,
            this.toolStripDropDownButton_ВвестиНаОснові,
            this.toolStripSeparator1,
            this.сomboBox_ТипПеріоду});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1011, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::StorageAndTrade.Properties.Resources.add_document;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonAdd.Text = "Додати";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = global::StorageAndTrade.Properties.Resources.doc_text_image;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonEdit.Text = "Редагувати";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::StorageAndTrade.Properties.Resources.page_refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(82, 22);
            this.toolStripButtonRefresh.Text = "Обновити";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.Image = global::StorageAndTrade.Properties.Resources.page_copy;
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(85, 22);
            this.toolStripButtonCopy.Text = "Копіювати";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = global::StorageAndTrade.Properties.Resources.page_white_delete;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonDelete.Text = "Видалити";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonДрукПроводок
            // 
            this.toolStripButtonДрукПроводок.Image = global::StorageAndTrade.Properties.Resources.page_2;
            this.toolStripButtonДрукПроводок.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonДрукПроводок.Name = "toolStripButtonДрукПроводок";
            this.toolStripButtonДрукПроводок.Size = new System.Drawing.Size(82, 22);
            this.toolStripButtonДрукПроводок.Text = "Проводки";
            this.toolStripButtonДрукПроводок.Click += new System.EventHandler(this.toolStripButtonДрукПроводок_Click);
            // 
            // toolStripButtonClearSpend
            // 
            this.toolStripButtonClearSpend.Image = global::StorageAndTrade.Properties.Resources.report;
            this.toolStripButtonClearSpend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearSpend.Name = "toolStripButtonClearSpend";
            this.toolStripButtonClearSpend.Size = new System.Drawing.Size(111, 22);
            this.toolStripButtonClearSpend.Text = "Не проведений";
            this.toolStripButtonClearSpend.Click += new System.EventHandler(this.toolStripButtonClearSpend_Click);
            // 
            // toolStripButtonSpend
            // 
            this.toolStripButtonSpend.Image = global::StorageAndTrade.Properties.Resources.report;
            this.toolStripButtonSpend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSpend.Name = "toolStripButtonSpend";
            this.toolStripButtonSpend.Size = new System.Drawing.Size(80, 22);
            this.toolStripButtonSpend.Text = "Провести";
            this.toolStripButtonSpend.Click += new System.EventHandler(this.toolStripButtonSpend_Click);
            // 
            // toolStripDropDownButton_ВвестиНаОснові
            // 
            this.toolStripDropDownButton_ВвестиНаОснові.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реалізаціяТоварівТаПослугtoolStripMenuItem,
            this.замовленняПостачальникуtoolStripMenuItem,
            this.поступленняТоварівТаПослугToolStripMenuItem});
            this.toolStripDropDownButton_ВвестиНаОснові.Image = global::StorageAndTrade.Properties.Resources.down;
            this.toolStripDropDownButton_ВвестиНаОснові.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_ВвестиНаОснові.Name = "toolStripDropDownButton_ВвестиНаОснові";
            this.toolStripDropDownButton_ВвестиНаОснові.Size = new System.Drawing.Size(128, 22);
            this.toolStripDropDownButton_ВвестиНаОснові.Text = "Ввести на основі";
            // 
            // реалізаціяТоварівТаПослугtoolStripMenuItem
            // 
            this.реалізаціяТоварівТаПослугtoolStripMenuItem.Image = global::StorageAndTrade.Properties.Resources.add_document;
            this.реалізаціяТоварівТаПослугtoolStripMenuItem.Name = "реалізаціяТоварівТаПослугtoolStripMenuItem";
            this.реалізаціяТоварівТаПослугtoolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.реалізаціяТоварівТаПослугtoolStripMenuItem.Text = "Реалізація товарів та послуг";
            this.реалізаціяТоварівТаПослугtoolStripMenuItem.Click += new System.EventHandler(this.реалізаціяТоварівТаПослугtoolStripMenuItem_Click);
            // 
            // замовленняПостачальникуtoolStripMenuItem
            // 
            this.замовленняПостачальникуtoolStripMenuItem.Image = global::StorageAndTrade.Properties.Resources.add_document;
            this.замовленняПостачальникуtoolStripMenuItem.Name = "замовленняПостачальникуtoolStripMenuItem";
            this.замовленняПостачальникуtoolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.замовленняПостачальникуtoolStripMenuItem.Text = "Замовлення постачальнику";
            this.замовленняПостачальникуtoolStripMenuItem.Click += new System.EventHandler(this.замовленняПостачальникуtoolStripMenuItem_Click);
            // 
            // поступленняТоварівТаПослугToolStripMenuItem
            // 
            this.поступленняТоварівТаПослугToolStripMenuItem.Image = global::StorageAndTrade.Properties.Resources.add_document;
            this.поступленняТоварівТаПослугToolStripMenuItem.Name = "поступленняТоварівТаПослугToolStripMenuItem";
            this.поступленняТоварівТаПослугToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.поступленняТоварівТаПослугToolStripMenuItem.Text = "Поступлення товарів та послуг";
            this.поступленняТоварівТаПослугToolStripMenuItem.Click += new System.EventHandler(this.поступленняТоварівТаПослугToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // сomboBox_ТипПеріоду
            // 
            this.сomboBox_ТипПеріоду.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.сomboBox_ТипПеріоду.Name = "сomboBox_ТипПеріоду";
            this.сomboBox_ТипПеріоду.Size = new System.Drawing.Size(140, 25);
            this.сomboBox_ТипПеріоду.SelectedIndexChanged += new System.EventHandler(this.сomboBox_ТипПеріоду_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewRecords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 549);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.Size = new System.Drawing.Size(1011, 549);
            this.dataGridViewRecords.TabIndex = 0;
            this.dataGridViewRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecords_CellClick);
            this.dataGridViewRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecords_CellDoubleClick);
            // 
            // Form_ЗамовленняКлієнтаЖурнал
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ЗамовленняКлієнтаЖурнал";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замовлення клієнтів - Журнал";
            this.Load += new System.EventHandler(this.Form_ЗамовленняКлієнтаЖурнал_Load);
            this.Shown += new System.EventHandler(this.Form_ЗамовленняКлієнтаЖурнал_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonДрукПроводок;
        private System.Windows.Forms.ToolStripButton toolStripButtonSpend;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearSpend;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_ВвестиНаОснові;
        private System.Windows.Forms.ToolStripMenuItem реалізаціяТоварівТаПослугtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняПостачальникуtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поступленняТоварівТаПослугToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox сomboBox_ТипПеріоду;
    }
}