namespace SOLID.LISKOV
{
    partial class FormView
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
            this.btnCustomerDiscount = new System.Windows.Forms.Button();
            this.lstCustomerDiscount = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerDiscount
            // 
            this.btnCustomerDiscount.Location = new System.Drawing.Point(35, 33);
            this.btnCustomerDiscount.Name = "btnCustomerDiscount";
            this.btnCustomerDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerDiscount.TabIndex = 0;
            this.btnCustomerDiscount.Text = "Add";
            this.btnCustomerDiscount.UseVisualStyleBackColor = true;
            this.btnCustomerDiscount.Click += new System.EventHandler(this.btnCustomerDiscount_Click);
            // 
            // lstCustomerDiscount
            // 
            this.lstCustomerDiscount.Location = new System.Drawing.Point(158, 33);
            this.lstCustomerDiscount.Name = "lstCustomerDiscount";
            this.lstCustomerDiscount.Size = new System.Drawing.Size(306, 135);
            this.lstCustomerDiscount.TabIndex = 1;
            this.lstCustomerDiscount.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add RefectorInvoice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCustomerDiscount);
            this.Controls.Add(this.btnCustomerDiscount);
            this.Name = "FormView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerDiscount;
        private System.Windows.Forms.ListView lstCustomerDiscount;
        private System.Windows.Forms.Button button1;
    }
}

