namespace Sum200
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHalf = new System.Windows.Forms.Label();
            this.txtHalf = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHalf
            // 
            this.lblHalf.AutoSize = true;
            this.lblHalf.Location = new System.Drawing.Point(153, 76);
            this.lblHalf.Name = "lblHalf";
            this.lblHalf.Size = new System.Drawing.Size(93, 17);
            this.lblHalf.TabIndex = 1;
            this.lblHalf.Text = "Halfway Total";
            // 
            // txtHalf
            // 
            this.txtHalf.Location = new System.Drawing.Point(12, 73);
            this.txtHalf.Name = "txtHalf";
            this.txtHalf.Size = new System.Drawing.Size(135, 22);
            this.txtHalf.TabIndex = 2;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(12, 110);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(135, 22);
            this.txtSum.TabIndex = 4;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(153, 114);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(36, 17);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Sum";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 167);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtHalf);
            this.Controls.Add(this.lblHalf);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Sum 200";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHalf;
        private System.Windows.Forms.TextBox txtHalf;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
    }
}

