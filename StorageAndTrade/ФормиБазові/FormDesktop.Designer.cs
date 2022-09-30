
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DownLoadXml);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelEndDownload);
            this.panel1.Controls.Add(this.dataGridViewRecords);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 489);
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
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Історія";
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
            this.dataGridViewRecords.Location = new System.Drawing.Point(4, 44);
            this.dataGridViewRecords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecords.Size = new System.Drawing.Size(378, 442);
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
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 512);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Завантаження курсу валют";
            // 
            // FormDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(947, 576);
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
    }
}