namespace OS_Project
{
    partial class miform
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
            this.pcinfolab = new System.Windows.Forms.Label();
            this.infobx = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pcinfolab
            // 
            this.pcinfolab.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcinfolab.Location = new System.Drawing.Point(530, 51);
            this.pcinfolab.Name = "pcinfolab";
            this.pcinfolab.Size = new System.Drawing.Size(846, 174);
            this.pcinfolab.TabIndex = 19;
            this.pcinfolab.Text = "Memory Information";
            this.pcinfolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infobx
            // 
            this.infobx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobx.Location = new System.Drawing.Point(177, 533);
            this.infobx.Multiline = true;
            this.infobx.Name = "infobx";
            this.infobx.Size = new System.Drawing.Size(1627, 627);
            this.infobx.TabIndex = 18;
            this.infobx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.SystemColors.Info;
            this.startbtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(790, 308);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(354, 140);
            this.startbtn.TabIndex = 17;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // miform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1980, 1210);
            this.Controls.Add(this.pcinfolab);
            this.Controls.Add(this.infobx);
            this.Controls.Add(this.startbtn);
            this.Name = "miform";
            this.Text = "miform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pcinfolab;
        private System.Windows.Forms.TextBox infobx;
        private System.Windows.Forms.Button startbtn;
    }
}