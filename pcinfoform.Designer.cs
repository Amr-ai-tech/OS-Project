namespace OS_Project
{
    partial class pcinfoform
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
            this.startbtn = new System.Windows.Forms.Button();
            this.infobx = new System.Windows.Forms.TextBox();
            this.pcinfolab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.SystemColors.Info;
            this.startbtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(809, 266);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(354, 140);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // infobx
            // 
            this.infobx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobx.Location = new System.Drawing.Point(196, 491);
            this.infobx.Multiline = true;
            this.infobx.Name = "infobx";
            this.infobx.Size = new System.Drawing.Size(1627, 627);
            this.infobx.TabIndex = 1;
            this.infobx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pcinfolab
            // 
            this.pcinfolab.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcinfolab.Location = new System.Drawing.Point(549, 9);
            this.pcinfolab.Name = "pcinfolab";
            this.pcinfolab.Size = new System.Drawing.Size(846, 174);
            this.pcinfolab.TabIndex = 7;
            this.pcinfolab.Text = "Computer Information";
            this.pcinfolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcinfoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2054, 1208);
            this.Controls.Add(this.pcinfolab);
            this.Controls.Add(this.infobx);
            this.Controls.Add(this.startbtn);
            this.Name = "pcinfoform";
            this.Text = "pcinfoform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.TextBox infobx;
        private System.Windows.Forms.Label pcinfolab;
    }
}