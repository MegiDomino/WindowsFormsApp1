namespace WindowsFormsApp1
{
    partial class ADDPAYMENT
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
            this.PAY = new System.Windows.Forms.Button();
            this.PAYMENTOPTION = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAYMENT OPTION";
            // 
            // PAY
            // 
            this.PAY.Location = new System.Drawing.Point(124, 217);
            this.PAY.Name = "PAY";
            this.PAY.Size = new System.Drawing.Size(135, 23);
            this.PAY.TabIndex = 2;
            this.PAY.Text = "PROCEED PAYMENT";
            this.PAY.UseVisualStyleBackColor = true;
            this.PAY.Click += new System.EventHandler(this.PAY_Click);
            // 
            // PAYMENTOPTION
            // 
            this.PAYMENTOPTION.FormattingEnabled = true;
            this.PAYMENTOPTION.Items.AddRange(new object[] {
            "GCASH",
            "PAYMAYA",
            "GOTYME",
            "PAYPAL"});
            this.PAYMENTOPTION.Location = new System.Drawing.Point(138, 175);
            this.PAYMENTOPTION.Name = "PAYMENTOPTION";
            this.PAYMENTOPTION.Size = new System.Drawing.Size(121, 21);
            this.PAYMENTOPTION.TabIndex = 3;
            // 
            // ADDPAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.PAYMENTOPTION);
            this.Controls.Add(this.PAY);
            this.Controls.Add(this.label1);
            this.Name = "ADDPAYMENT";
            this.Text = "ADDPAYMENT";
            this.Load += new System.EventHandler(this.ADDPAYMENT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PAY;
        private System.Windows.Forms.ComboBox PAYMENTOPTION;
    }
}