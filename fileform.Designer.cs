namespace OS_Project
{
    partial class fileform
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
            this.mkfilebtn = new System.Windows.Forms.Button();
            this.mkfilelsb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mkfilebtn
            // 
            this.mkfilebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mkfilebtn.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkfilebtn.Location = new System.Drawing.Point(133, 518);
            this.mkfilebtn.Name = "mkfilebtn";
            this.mkfilebtn.Size = new System.Drawing.Size(340, 119);
            this.mkfilebtn.TabIndex = 0;
            this.mkfilebtn.Text = "Click";
            this.mkfilebtn.UseVisualStyleBackColor = false;
            this.mkfilebtn.Click += new System.EventHandler(this.mkfilebtn_Click);
            // 
            // mkfilelsb
            // 
            this.mkfilelsb.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkfilelsb.Location = new System.Drawing.Point(46, 298);
            this.mkfilelsb.Name = "mkfilelsb";
            this.mkfilelsb.Size = new System.Drawing.Size(512, 206);
            this.mkfilelsb.TabIndex = 1;
            this.mkfilelsb.Text = "Create a file";
            this.mkfilelsb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1224, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 206);
            this.label1.TabIndex = 2;
            this.label1.Text = "Read from file";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 206);
            this.label2.TabIndex = 3;
            this.label2.Text = "Write to file ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(735, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 119);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1367, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 119);
            this.button2.TabIndex = 5;
            this.button2.Text = "Click";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1873, 1193);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mkfilelsb);
            this.Controls.Add(this.mkfilebtn);
            this.Name = "fileform";
            this.Text = "fileform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mkfilebtn;
        private System.Windows.Forms.Label mkfilelsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}