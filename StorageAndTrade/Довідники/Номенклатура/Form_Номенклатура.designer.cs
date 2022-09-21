﻿
namespace StorageAndTrade
{
    partial class Form_Номенклатура
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Номенклатура));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.товариНаСкладахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.Номенклатура_Папки_Дерево = new StorageAndTrade.Form_Номенклатура_Папки_Дерево();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(890, 33);
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
            this.toolStripSeparator1,
            this.toolStripDropDownButtonReport,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButtonReport
            // 
            this.toolStripDropDownButtonReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товариНаСкладахToolStripMenuItem,
            this.партіїToolStripMenuItem});
            this.toolStripDropDownButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonReport.Image")));
            this.toolStripDropDownButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonReport.Name = "toolStripDropDownButtonReport";
            this.toolStripDropDownButtonReport.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButtonReport.Text = "Звіт";
            // 
            // товариНаСкладахToolStripMenuItem
            // 
            this.товариНаСкладахToolStripMenuItem.Name = "товариНаСкладахToolStripMenuItem";
            this.товариНаСкладахToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.товариНаСкладахToolStripMenuItem.Text = "Залишки";
            this.товариНаСкладахToolStripMenuItem.Click += new System.EventHandler(this.товариНаСкладахToolStripMenuItem_Click);
            // 
            // партіїToolStripMenuItem
            // 
            this.партіїToolStripMenuItem.Name = "партіїToolStripMenuItem";
            this.партіїToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.партіїToolStripMenuItem.Text = "Партії";
            this.партіїToolStripMenuItem.Click += new System.EventHandler(this.партіїToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::StorageAndTrade.Properties.Resources.layers;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 22);
            this.toolStripButton1.Text = "Штрих-коди";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 593);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewRecords);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Номенклатура_Папки_Дерево);
            this.splitContainer1.Size = new System.Drawing.Size(890, 593);
            this.splitContainer1.SplitterDistance = 622;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecords.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewRecords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewRecords.Size = new System.Drawing.Size(622, 593);
            this.dataGridViewRecords.TabIndex = 0;
            this.dataGridViewRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecords_CellClick);
            this.dataGridViewRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecords_CellDoubleClick);
            // 
            // Номенклатура_Папки_Дерево
            // 
            this.Номенклатура_Папки_Дерево.CallBack_AfterSelect = null;
            this.Номенклатура_Папки_Дерево.CallBack_DoubleClick = null;
            this.Номенклатура_Папки_Дерево.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Номенклатура_Папки_Дерево.Location = new System.Drawing.Point(0, 0);
            this.Номенклатура_Папки_Дерево.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Номенклатура_Папки_Дерево.Name = "Номенклатура_Папки_Дерево";
            this.Номенклатура_Папки_Дерево.Size = new System.Drawing.Size(263, 593);
            this.Номенклатура_Папки_Дерево.TabIndex = 0;
            this.Номенклатура_Папки_Дерево.UidOpenFolder = null;
            // 
            // Form_Номенклатура
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Номенклатура";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Номенклатура";
            this.Load += new System.EventHandler(this.Form_Номенклатура_Load);
            this.Shown += new System.EventHandler(this.Form_Номенклатура_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Form_Номенклатура_Папки_Дерево Номенклатура_Папки_Дерево;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonReport;
        private System.Windows.Forms.ToolStripMenuItem товариНаСкладахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}