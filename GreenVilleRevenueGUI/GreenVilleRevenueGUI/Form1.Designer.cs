namespace GreenVilleRevenueGUI
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Contestants Last Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Contestants This Year";
            // 
            // txtBoxLastYear
            // 
            this.txtBoxLastYear.Location = new System.Drawing.Point(202, 13);
            this.txtBoxLastYear.Name = "txtBoxLastYear";
            this.txtBoxLastYear.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLastYear.TabIndex = 2;
            // 
            // txtBoxThisYear
            // 
            this.txtBoxThisYear.Location = new System.Drawing.Point(202, 45);
            this.txtBoxThisYear.Name = "txtBoxThisYear";
            this.txtBoxThisYear.Size = new System.Drawing.Size(100, 20);
            this.txtBoxThisYear.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(54, 103);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(151, 49);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate Revenue";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevenue.Location = new System.Drawing.Point(488, 14);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(178, 111);
            this.lblRevenue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 387);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.btnCalc);
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
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblRevenue;
    }
}

