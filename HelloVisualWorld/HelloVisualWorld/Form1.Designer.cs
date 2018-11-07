namespace HelloVisualWorld
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.btnClickLast = new System.Windows.Forms.Button();
            this.btnReallyLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.Location = new System.Drawing.Point(162, 40);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(100, 23);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, Visual World!";
            this.lblHello.Visible = false;
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(165, 109);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(75, 23);
            this.btnClickHere.TabIndex = 1;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // btnClickLast
            // 
            this.btnClickLast.Location = new System.Drawing.Point(156, 171);
            this.btnClickLast.Name = "btnClickLast";
            this.btnClickLast.Size = new System.Drawing.Size(84, 23);
            this.btnClickLast.TabIndex = 2;
            this.btnClickLast.Text = "Click Me Last";
            this.btnClickLast.UseVisualStyleBackColor = true;
            this.btnClickLast.Click += new System.EventHandler(this.btnClickLast_Click);
            // 
            // btnReallyLast
            // 
            this.btnReallyLast.Location = new System.Drawing.Point(130, 243);
            this.btnReallyLast.Name = "btnReallyLast";
            this.btnReallyLast.Size = new System.Drawing.Size(132, 23);
            this.btnReallyLast.TabIndex = 3;
            this.btnReallyLast.Text = "No Really Click Me Last";
            this.btnReallyLast.UseVisualStyleBackColor = true;
            this.btnReallyLast.Click += new System.EventHandler(this.btnReallyLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 359);
            this.Controls.Add(this.btnReallyLast);
            this.Controls.Add(this.btnClickLast);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "HelloVisualWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Button btnClickLast;
        private System.Windows.Forms.Button btnReallyLast;
    }
}

