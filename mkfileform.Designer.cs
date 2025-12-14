namespace OS_Project
{
    partial class mkfileform
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
            this.crbtn = new System.Windows.Forms.Button();
            this.mlab = new System.Windows.Forms.Label();
            this.pathpx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crbtn
            // 
            this.crbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.crbtn.Font = new System.Drawing.Font("MV Boli", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crbtn.Location = new System.Drawing.Point(753, 664);
            this.crbtn.Name = "crbtn";
            this.crbtn.Size = new System.Drawing.Size(425, 415);
            this.crbtn.TabIndex = 0;
            this.crbtn.Text = "Create";
            this.crbtn.UseVisualStyleBackColor = false;
            this.crbtn.Click += new System.EventHandler(this.crbtn_Click);
            // 
            // mlab
            // 
            this.mlab.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlab.Location = new System.Drawing.Point(536, 9);
            this.mlab.Name = "mlab";
            this.mlab.Size = new System.Drawing.Size(837, 151);
            this.mlab.TabIndex = 1;
            this.mlab.Text = "Creating a file ";
            this.mlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathpx
            // 
            this.pathpx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathpx.Location = new System.Drawing.Point(837, 330);
            this.pathpx.Multiline = true;
            this.pathpx.Name = "pathpx";
            this.pathpx.Size = new System.Drawing.Size(1029, 100);
            this.pathpx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 151);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the path here :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mkfileform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1989, 1172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathpx);
            this.Controls.Add(this.mlab);
            this.Controls.Add(this.crbtn);
            this.Name = "mkfileform";
            this.Text = "mkfileform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crbtn;
        private System.Windows.Forms.Label mlab;
        private System.Windows.Forms.TextBox pathpx;
        private System.Windows.Forms.Label label1;
    }
}