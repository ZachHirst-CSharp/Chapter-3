namespace PayrollGUI
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSSN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxHourlyPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblFederal = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(118, 39);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(265, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Social Security Number";
            // 
            // txtBoxSSN
            // 
            this.txtBoxSSN.Location = new System.Drawing.Point(402, 33);
            this.txtBoxSSN.Name = "txtBoxSSN";
            this.txtBoxSSN.Size = new System.Drawing.Size(108, 20);
            this.txtBoxSSN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(60, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hourly Rate Pay";
            // 
            // txtBoxHourlyPay
            // 
            this.txtBoxHourlyPay.Location = new System.Drawing.Point(184, 83);
            this.txtBoxHourlyPay.Name = "txtBoxHourlyPay";
            this.txtBoxHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHourlyPay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(338, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours Worked";
            // 
            // txtBoxHoursWorked
            // 
            this.txtBoxHoursWorked.Location = new System.Drawing.Point(451, 78);
            this.txtBoxHoursWorked.Name = "txtBoxHoursWorked";
            this.txtBoxHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHoursWorked.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPay.Location = new System.Drawing.Point(27, 261);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(389, 23);
            this.lblGrossPay.TabIndex = 9;
            // 
            // lblFederal
            // 
            this.lblFederal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFederal.Location = new System.Drawing.Point(27, 295);
            this.lblFederal.Name = "lblFederal";
            this.lblFederal.Size = new System.Drawing.Size(389, 23);
            this.lblFederal.TabIndex = 10;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(27, 327);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(389, 23);
            this.lblState.TabIndex = 11;
            // 
            // lblNet
            // 
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNet.Location = new System.Drawing.Point(27, 359);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(389, 23);
            this.lblNet.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFederal);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxHoursWorked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHourlyPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxHourlyPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxHoursWorked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblFederal;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNet;
    }
}

