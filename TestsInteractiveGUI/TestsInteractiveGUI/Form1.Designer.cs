namespace TestsInteractiveGUI
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
            this.txtBoxTest1 = new System.Windows.Forms.TextBox();
            this.txtBoxTest2 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.txtBoxTest3 = new System.Windows.Forms.TextBox();
            this.txtBoxTest4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxTest1
            // 
            this.txtBoxTest1.Location = new System.Drawing.Point(12, 50);
            this.txtBoxTest1.Name = "txtBoxTest1";
            this.txtBoxTest1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest1.TabIndex = 0;
            // 
            // txtBoxTest2
            // 
            this.txtBoxTest2.Location = new System.Drawing.Point(160, 50);
            this.txtBoxTest2.Name = "txtBoxTest2";
            this.txtBoxTest2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest2.TabIndex = 1;
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(614, 50);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(100, 20);
            this.txtBox5.TabIndex = 2;
            // 
            // txtBoxTest3
            // 
            this.txtBoxTest3.Location = new System.Drawing.Point(309, 50);
            this.txtBoxTest3.Name = "txtBoxTest3";
            this.txtBoxTest3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest3.TabIndex = 3;
            // 
            // txtBoxTest4
            // 
            this.txtBoxTest4.Location = new System.Drawing.Point(466, 50);
            this.txtBoxTest4.Name = "txtBoxTest4";
            this.txtBoxTest4.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTest4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter 5 different test scores for an average";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "btnCalc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(309, 181);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 349);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTest4);
            this.Controls.Add(this.txtBoxTest3);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBoxTest2);
            this.Controls.Add(this.txtBoxTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTest1;
        private System.Windows.Forms.TextBox txtBoxTest2;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.TextBox txtBoxTest3;
        private System.Windows.Forms.TextBox txtBoxTest4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}

