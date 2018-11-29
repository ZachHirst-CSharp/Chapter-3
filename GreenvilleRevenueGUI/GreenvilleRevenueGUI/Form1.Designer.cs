namespace GreenvilleRevenueGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLastYear = new System.Windows.Forms.TextBox();
            this.txtBoxThisYear = new System.Windows.Forms.TextBox();
            this.btnRev = new System.Windows.Forms.Button();
            this.lblBigger = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of contestants last year..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(623, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of contestants this year...";
            // 
            // txtBoxLastYear
            // 
            this.txtBoxLastYear.Location = new System.Drawing.Point(13, 58);
            this.txtBoxLastYear.Name = "txtBoxLastYear";
            this.txtBoxLastYear.Size = new System.Drawing.Size(163, 20);
            this.txtBoxLastYear.TabIndex = 2;
            // 
            // txtBoxThisYear
            // 
            this.txtBoxThisYear.Location = new System.Drawing.Point(623, 58);
            this.txtBoxThisYear.Name = "txtBoxThisYear";
            this.txtBoxThisYear.Size = new System.Drawing.Size(167, 20);
            this.txtBoxThisYear.TabIndex = 3;
            // 
            // btnRev
            // 
            this.btnRev.Location = new System.Drawing.Point(241, 58);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(291, 28);
            this.btnRev.TabIndex = 4;
            this.btnRev.Text = "Revenue?";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // lblBigger
            // 
            this.lblBigger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBigger.Location = new System.Drawing.Point(13, 117);
            this.lblBigger.Name = "lblBigger";
            this.lblBigger.Size = new System.Drawing.Size(361, 23);
            this.lblBigger.TabIndex = 5;
            this.lblBigger.Visible = false;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevenue.Location = new System.Drawing.Point(13, 159);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(361, 23);
            this.lblRevenue.TabIndex = 6;
            this.lblRevenue.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblBigger);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.txtBoxThisYear);
            this.Controls.Add(this.txtBoxLastYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLastYear;
        private System.Windows.Forms.TextBox txtBoxThisYear;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Label lblBigger;
        private System.Windows.Forms.Label lblRevenue;
    }
}

