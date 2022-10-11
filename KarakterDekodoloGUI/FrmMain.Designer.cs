namespace KarakterDekodoloGUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKarakter = new System.Windows.Forms.Label();
            this.tbKarakter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKarakter
            // 
            this.lblKarakter.AutoSize = true;
            this.lblKarakter.Location = new System.Drawing.Point(128, 42);
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(82, 25);
            this.lblKarakter.TabIndex = 0;
            this.lblKarakter.Text = "Karakter";
            // 
            // tbKarakter
            // 
            this.tbKarakter.Location = new System.Drawing.Point(216, 28);
            this.tbKarakter.MaximumSize = new System.Drawing.Size(50, 50);
            this.tbKarakter.MinimumSize = new System.Drawing.Size(50, 50);
            this.tbKarakter.Name = "tbKarakter";
            this.tbKarakter.Size = new System.Drawing.Size(50, 50);
            this.tbKarakter.TabIndex = 1;
            this.tbKarakter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 564);
            this.Controls.Add(this.tbKarakter);
            this.Controls.Add(this.lblKarakter);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKarakter;
        private TextBox tbKarakter;
    }
}