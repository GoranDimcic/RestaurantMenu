
namespace Neo4J_Repository.View
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPayTheBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddCustomer.BackgroundImage")));
            this.BtnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddCustomer.Location = new System.Drawing.Point(50, 100);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(150, 150);
            this.BtnAddCustomer.TabIndex = 1;
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pay the bill";
            // 
            // BtnPayTheBill
            // 
            this.BtnPayTheBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPayTheBill.BackgroundImage")));
            this.BtnPayTheBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPayTheBill.Location = new System.Drawing.Point(350, 100);
            this.BtnPayTheBill.Name = "BtnPayTheBill";
            this.BtnPayTheBill.Size = new System.Drawing.Size(150, 150);
            this.BtnPayTheBill.TabIndex = 6;
            this.BtnPayTheBill.UseVisualStyleBackColor = true;
            this.BtnPayTheBill.Click += new System.EventHandler(this.BtnPayTheBill_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnPayTheBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddCustomer);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPayTheBill;
    }
}