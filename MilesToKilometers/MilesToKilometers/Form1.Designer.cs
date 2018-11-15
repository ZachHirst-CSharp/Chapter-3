namespace MilesToKilometers
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
            this.btnCompile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxmiles = new System.Windows.Forms.TextBox();
            this.lblkilo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(140, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance in miles";
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(306, 105);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(75, 23);
            this.btnCompile.TabIndex = 2;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance in kilometers";
            // 
            // textBoxmiles
            // 
            this.textBoxmiles.Location = new System.Drawing.Point(283, 36);
            this.textBoxmiles.Name = "textBoxmiles";
            this.textBoxmiles.Size = new System.Drawing.Size(100, 20);
            this.textBoxmiles.TabIndex = 4;
            // 
            // lblkilo
            // 
            this.lblkilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblkilo.Location = new System.Drawing.Point(268, 219);
            this.lblkilo.Name = "lblkilo";
            this.lblkilo.Size = new System.Drawing.Size(100, 23);
            this.lblkilo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkilo);
            this.Controls.Add(this.textBoxmiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmiles;
        private System.Windows.Forms.Label lblkilo;
    }
}

