namespace OS_Project
{
    partial class readfileform
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
            this.pathpx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mlab = new System.Windows.Forms.Label();
            this.wrbtn = new System.Windows.Forms.Button();
            this.txtpx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathpx
            // 
            this.pathpx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathpx.Location = new System.Drawing.Point(734, 291);
            this.pathpx.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pathpx.Multiline = true;
            this.pathpx.Name = "pathpx";
            this.pathpx.Size = new System.Drawing.Size(1176, 73);
            this.pathpx.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-18, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 67);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter the path here :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlab
            // 
            this.mlab.Font = new System.Drawing.Font("MV Boli", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlab.Location = new System.Drawing.Point(436, 76);
            this.mlab.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mlab.Name = "mlab";
            this.mlab.Size = new System.Drawing.Size(847, 98);
            this.mlab.TabIndex = 19;
            this.mlab.Text = "Reading from file ";
            this.mlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrbtn
            // 
            this.wrbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.wrbtn.Font = new System.Drawing.Font("MV Boli", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrbtn.Location = new System.Drawing.Point(65, 736);
            this.wrbtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.wrbtn.Name = "wrbtn";
            this.wrbtn.Size = new System.Drawing.Size(422, 301);
            this.wrbtn.TabIndex = 18;
            this.wrbtn.Text = "Read";
            this.wrbtn.UseVisualStyleBackColor = false;
            this.wrbtn.Click += new System.EventHandler(this.wrbtn_Click);
            // 
            // txtpx
            // 
            this.txtpx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpx.Location = new System.Drawing.Point(681, 616);
            this.txtpx.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtpx.Multiline = true;
            this.txtpx.Name = "txtpx";
            this.txtpx.Size = new System.Drawing.Size(1186, 567);
            this.txtpx.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 525);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 67);
            this.label1.TabIndex = 16;
            this.label1.Text = "your text :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readfileform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1988, 1278);
            this.Controls.Add(this.pathpx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mlab);
            this.Controls.Add(this.wrbtn);
            this.Controls.Add(this.txtpx);
            this.Controls.Add(this.label1);
            this.Name = "readfileform";
            this.Text = "readfileform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathpx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mlab;
        private System.Windows.Forms.Button wrbtn;
        private System.Windows.Forms.TextBox txtpx;
        private System.Windows.Forms.Label label1;
    }
}