namespace OS_Project
{
    partial class startform
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
            this.filebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filebtn
            // 
            this.filebtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.filebtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filebtn.Location = new System.Drawing.Point(688, 230);
            this.filebtn.Name = "filebtn";
            this.filebtn.Size = new System.Drawing.Size(440, 153);
            this.filebtn.TabIndex = 0;
            this.filebtn.Text = "Click";
            this.filebtn.UseVisualStyleBackColor = false;
            this.filebtn.Click += new System.EventHandler(this.filebtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1132, 148);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Mangement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1148, 148);
            this.label2.TabIndex = 3;
            this.label2.Text = "System Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.CadetBlue;
            this.infobtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobtn.Location = new System.Drawing.Point(688, 740);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(440, 158);
            this.infobtn.TabIndex = 4;
            this.infobtn.Text = "Click";
            this.infobtn.UseVisualStyleBackColor = false;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1882, 1046);
            this.Controls.Add(this.infobtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filebtn);
            this.Name = "startform";
            this.Text = "startform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button infobtn;
    }
}