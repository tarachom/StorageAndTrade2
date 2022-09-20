
namespace StorageAndTrade
{
    partial class NumericControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumeric = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumeric
            // 
            this.textBoxNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumeric.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumeric.Location = new System.Drawing.Point(0, 0);
            this.textBoxNumeric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNumeric.Name = "textBoxNumeric";
            this.textBoxNumeric.Size = new System.Drawing.Size(210, 23);
            this.textBoxNumeric.TabIndex = 0;
            this.textBoxNumeric.TextChanged += new System.EventHandler(this.textBoxNumeric_TextChanged);
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(218, 3);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(11, 13);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "!";
            // 
            // NumericControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxNumeric);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NumericControl";
            this.Size = new System.Drawing.Size(239, 30);
            this.Load += new System.EventHandler(this.NumericControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeric;
        private System.Windows.Forms.Label labelError;
    }
}
