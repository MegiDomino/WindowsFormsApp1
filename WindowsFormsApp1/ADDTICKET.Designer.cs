namespace WindowsFormsApp1
{
    partial class ADDTICKET
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
            this.PRICE = new System.Windows.Forms.TextBox();
            this.BUS_ID = new System.Windows.Forms.TextBox();
            this.ROUTE_ID = new System.Windows.Forms.TextBox();
            this.SCHED = new System.Windows.Forms.TextBox();
            this.ADD_PAYMENT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STATUS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PRICE
            // 
            this.PRICE.Location = new System.Drawing.Point(311, 131);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(100, 20);
            this.PRICE.TabIndex = 0;
            // 
            // BUS_ID
            // 
            this.BUS_ID.Location = new System.Drawing.Point(311, 207);
            this.BUS_ID.Name = "BUS_ID";
            this.BUS_ID.Size = new System.Drawing.Size(100, 20);
            this.BUS_ID.TabIndex = 2;
            // 
            // ROUTE_ID
            // 
            this.ROUTE_ID.Location = new System.Drawing.Point(311, 250);
            this.ROUTE_ID.Name = "ROUTE_ID";
            this.ROUTE_ID.Size = new System.Drawing.Size(100, 20);
            this.ROUTE_ID.TabIndex = 3;
            // 
            // SCHED
            // 
            this.SCHED.Location = new System.Drawing.Point(311, 292);
            this.SCHED.Name = "SCHED";
            this.SCHED.Size = new System.Drawing.Size(100, 20);
            this.SCHED.TabIndex = 4;
            // 
            // ADD_PAYMENT
            // 
            this.ADD_PAYMENT.Location = new System.Drawing.Point(581, 340);
            this.ADD_PAYMENT.Name = "ADD_PAYMENT";
            this.ADD_PAYMENT.Size = new System.Drawing.Size(124, 23);
            this.ADD_PAYMENT.TabIndex = 5;
            this.ADD_PAYMENT.Text = "ADD PAYMENT";
            this.ADD_PAYMENT.UseVisualStyleBackColor = true;
            this.ADD_PAYMENT.Click += new System.EventHandler(this.ADD_PAYMENT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRICE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BUS ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ROUTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SCHEDULE";
            // 
            // STATUS
            // 
            this.STATUS.FormattingEnabled = true;
            this.STATUS.Items.AddRange(new object[] {
            "WAITING",
            "ONGOING"});
            this.STATUS.Location = new System.Drawing.Point(311, 171);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(121, 21);
            this.STATUS.TabIndex = 11;
            // 
            // ADDTICKET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADD_PAYMENT);
            this.Controls.Add(this.SCHED);
            this.Controls.Add(this.ROUTE_ID);
            this.Controls.Add(this.BUS_ID);
            this.Controls.Add(this.PRICE);
            this.Name = "ADDTICKET";
            this.Text = "ADDTICKET";
            this.Load += new System.EventHandler(this.ADDTICKET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PRICE;
        private System.Windows.Forms.TextBox BUS_ID;
        private System.Windows.Forms.TextBox ROUTE_ID;
        private System.Windows.Forms.TextBox SCHED;
        private System.Windows.Forms.Button ADD_PAYMENT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox STATUS;
    }
}