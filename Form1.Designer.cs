namespace OS_Project
{
    partial class mainform
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
            this.namelab = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.shutbtn = new System.Windows.Forms.Button();
            this.devbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelab
            // 
            this.namelab.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelab.Location = new System.Drawing.Point(341, 84);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(1201, 179);
            this.namelab.TabIndex = 0;
            this.namelab.Text = "System Assistant";
            this.namelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namelab.Click += new System.EventHandler(this.label1_Click);
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startbtn.Font = new System.Drawing.Font("MV Boli", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(714, 466);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(488, 152);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // shutbtn
            // 
            this.shutbtn.BackColor = System.Drawing.Color.IndianRed;
            this.shutbtn.Font = new System.Drawing.Font("MV Boli", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutbtn.Location = new System.Drawing.Point(1556, 908);
            this.shutbtn.Name = "shutbtn";
            this.shutbtn.Size = new System.Drawing.Size(285, 135);
            this.shutbtn.TabIndex = 2;
            this.shutbtn.Text = "Shut dowen";
            this.shutbtn.UseVisualStyleBackColor = false;
            this.shutbtn.Click += new System.EventHandler(this.shutbtn_Click);
            // 
            // devbtn
            // 
            this.devbtn.BackColor = System.Drawing.SystemColors.Info;
            this.devbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.devbtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devbtn.Location = new System.Drawing.Point(94, 908);
            this.devbtn.Name = "devbtn";
            this.devbtn.Size = new System.Drawing.Size(290, 135);
            this.devbtn.TabIndex = 3;
            this.devbtn.Text = "Developers";
            this.devbtn.UseVisualStyleBackColor = false;
            this.devbtn.Click += new System.EventHandler(this.devbtn_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1961, 1105);
            this.Controls.Add(this.devbtn);
            this.Controls.Add(this.shutbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.namelab);
            this.Name = "mainform";
            this.Text = "main form ";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button shutbtn;
        private System.Windows.Forms.Button devbtn;
    }
}

