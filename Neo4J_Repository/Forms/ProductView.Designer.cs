
namespace Neo4J_Repository.Forms
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.BtnCreateNewProduct = new System.Windows.Forms.Button();
            this.BtnAddProductToRestaurant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddProductType = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateNewProduct
            // 
            this.BtnCreateNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateNewProduct.BackgroundImage")));
            this.BtnCreateNewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCreateNewProduct.Location = new System.Drawing.Point(50, 150);
            this.BtnCreateNewProduct.Name = "BtnCreateNewProduct";
            this.BtnCreateNewProduct.Size = new System.Drawing.Size(150, 150);
            this.BtnCreateNewProduct.TabIndex = 0;
            this.BtnCreateNewProduct.UseVisualStyleBackColor = true;
            this.BtnCreateNewProduct.Click += new System.EventHandler(this.BtnCreateNewProduct_Click);
            // 
            // BtnAddProductToRestaurant
            // 
            this.BtnAddProductToRestaurant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddProductToRestaurant.BackgroundImage")));
            this.BtnAddProductToRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddProductToRestaurant.Location = new System.Drawing.Point(450, 150);
            this.BtnAddProductToRestaurant.Name = "BtnAddProductToRestaurant";
            this.BtnAddProductToRestaurant.Size = new System.Drawing.Size(150, 150);
            this.BtnAddProductToRestaurant.TabIndex = 2;
            this.BtnAddProductToRestaurant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create new product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add product to restaurant";
            // 
            // BtnAddProductType
            // 
            this.BtnAddProductType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddProductType.BackgroundImage")));
            this.BtnAddProductType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddProductType.Location = new System.Drawing.Point(250, 150);
            this.BtnAddProductType.Name = "BtnAddProductType";
            this.BtnAddProductType.Size = new System.Drawing.Size(150, 150);
            this.BtnAddProductType.TabIndex = 1;
            this.BtnAddProductType.UseVisualStyleBackColor = true;
            this.BtnAddProductType.Click += new System.EventHandler(this.BtnAddProductType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Create product type";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAddProductType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddProductToRestaurant);
            this.Controls.Add(this.BtnCreateNewProduct);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateNewProduct;
        private System.Windows.Forms.Button BtnAddProductToRestaurant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddProductType;
        private System.Windows.Forms.Label label3;
    }
}