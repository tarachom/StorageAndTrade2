namespace StorageAndTrade
{
    partial class Form_Номенклатура_Файли
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Номенклатура_Файли));
            this.Номенклатура_ТабличнаЧастина_Файли = new StorageAndTrade.Form_Номенклатура_ТабличнаЧастина_Файли();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Номенклатура_ТабличнаЧастина_Файли
            // 
            this.Номенклатура_ТабличнаЧастина_Файли.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Номенклатура_ТабличнаЧастина_Файли.Location = new System.Drawing.Point(13, 12);
            this.Номенклатура_ТабличнаЧастина_Файли.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Номенклатура_ТабличнаЧастина_Файли.Name = "Номенклатура_ТабличнаЧастина_Файли";
            this.Номенклатура_ТабличнаЧастина_Файли.Size = new System.Drawing.Size(850, 429);
            this.Номенклатура_ТабличнаЧастина_Файли.TabIndex = 0;
            this.Номенклатура_ТабличнаЧастина_Файли.ДовідникОбєкт = null;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(155, 447);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 31);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(13, 447);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 31);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Зберегти і закрити";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form_Номенклатура_Файли
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 490);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Номенклатура_ТабличнаЧастина_Файли);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Номенклатура_Файли";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файли елементу номенклатури";
            this.Load += new System.EventHandler(this.Form_Номенклатура_Файли_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Form_Номенклатура_ТабличнаЧастина_Файли Номенклатура_ТабличнаЧастина_Файли;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}