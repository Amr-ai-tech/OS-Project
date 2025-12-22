namespace OS_Project
{
    partial class devform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devform));
            this.dlab = new System.Windows.Forms.Label();
            this.Developers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dlab
            // 
            this.dlab.Font = new System.Drawing.Font("MV Boli", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlab.Location = new System.Drawing.Point(561, 115);
            this.dlab.Name = "dlab";
            this.dlab.Size = new System.Drawing.Size(757, 176);
            this.dlab.TabIndex = 0;
            this.dlab.Text = "Developers\r\n";
            this.dlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dlab.Click += new System.EventHandler(this.dlab_Click);
            // 
            // Developers
            // 
            this.Developers.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Developers.Location = new System.Drawing.Point(248, 271);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(1470, 803);
            this.Developers.TabIndex = 1;
            this.Developers.Text = resources.GetString("Developers.Text");
            this.Developers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(2007, 1130);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.dlab);
            this.Name = "devform";
            this.Text = "devform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dlab;
        private System.Windows.Forms.Label Developers;
    }
}