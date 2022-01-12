namespace Neo4J_Repository
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnRestaurant = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRestaurant
            // 
            this.BtnRestaurant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRestaurant.BackgroundImage")));
            this.BtnRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRestaurant.Location = new System.Drawing.Point(50, 150);
            this.BtnRestaurant.Name = "BtnRestaurant";
            this.BtnRestaurant.Size = new System.Drawing.Size(150, 150);
            this.BtnRestaurant.TabIndex = 0;
            this.BtnRestaurant.UseVisualStyleBackColor = true;
            this.BtnRestaurant.Click += new System.EventHandler(this.BtnRestaurant_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProduct.BackgroundImage")));
            this.BtnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProduct.Location = new System.Drawing.Point(250, 150);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(150, 150);
            this.BtnProduct.TabIndex = 1;
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCustomer.BackgroundImage")));
            this.BtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCustomer.Location = new System.Drawing.Point(450, 150);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(150, 150);
            this.BtnCustomer.TabIndex = 2;
            this.BtnCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.BtnProduct);
            this.Controls.Add(this.BtnRestaurant);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRestaurant;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}