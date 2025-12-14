namespace OS_Project
{
    partial class pc_rename_form
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
            this.renamebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pcinfolab
            // 
            this.pcinfolab.Font = new System.Drawing.Font("MV Boli", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcinfolab.Location = new System.Drawing.Point(530, 51);
            this.pcinfolab.Name = "pcinfolab";
            this.pcinfolab.Size = new System.Drawing.Size(846, 174);
            this.pcinfolab.TabIndex = 22;
            this.pcinfolab.Text = "Computer Rename";
            this.pcinfolab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infobx
            // 
            this.infobx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobx.Location = new System.Drawing.Point(964, 274);
            this.infobx.Multiline = true;
            this.infobx.Name = "infobx";
            this.infobx.Size = new System.Drawing.Size(839, 219);
            this.infobx.TabIndex = 21;
            this.infobx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // renamebtn
            // 
            this.renamebtn.BackColor = System.Drawing.SystemColors.Info;
            this.renamebtn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renamebtn.Location = new System.Drawing.Point(679, 742);
            this.renamebtn.Name = "renamebtn";
            this.renamebtn.Size = new System.Drawing.Size(485, 220);
            this.renamebtn.TabIndex = 20;
            this.renamebtn.Text = "Rename";
            this.renamebtn.UseVisualStyleBackColor = false;
            this.renamebtn.Click += new System.EventHandler(this.renamebtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 113);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter the new name here :";
            // 
            // pc_rename_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1980, 1210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcinfolab);
            this.Controls.Add(this.infobx);
            this.Controls.Add(this.renamebtn);
            this.Name = "pc_rename_form";
            this.Text = "pc_rename_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pcinfolab;
        private System.Windows.Forms.TextBox infobx;
        private System.Windows.Forms.Button renamebtn;
        private System.Windows.Forms.Label label1;
    }
}