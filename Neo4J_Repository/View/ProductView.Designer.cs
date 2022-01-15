
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
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCreateProductType = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateNewProduct
            // 
            this.BtnCreateNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateNewProduct.BackgroundImage")));
            this.BtnCreateNewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCreateNewProduct.Location = new System.Drawing.Point(250, 100);
            this.BtnCreateNewProduct.Name = "BtnCreateNewProduct";
            this.BtnCreateNewProduct.Size = new System.Drawing.Size(150, 150);
            this.BtnCreateNewProduct.TabIndex = 0;
            this.BtnCreateNewProduct.UseVisualStyleBackColor = true;
            this.BtnCreateNewProduct.Click += new System.EventHandler(this.BtnCreateNewProduct_Click);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdateProduct.BackgroundImage")));
            this.BtnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdateProduct.Location = new System.Drawing.Point(450, 100);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(150, 150);
            this.BtnUpdateProduct.TabIndex = 2;
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create new product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update product";
            // 
            // BtnCreateProductType
            // 
            this.BtnCreateProductType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateProductType.BackgroundImage")));
            this.BtnCreateProductType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCreateProductType.Location = new System.Drawing.Point(50, 100);
            this.BtnCreateProductType.Name = "BtnCreateProductType";
            this.BtnCreateProductType.Size = new System.Drawing.Size(150, 150);
            this.BtnCreateProductType.TabIndex = 1;
            this.BtnCreateProductType.UseVisualStyleBackColor = true;
            this.BtnCreateProductType.Click += new System.EventHandler(this.BtnCreateProductType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 275);
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
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCreateProductType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.BtnCreateNewProduct);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateNewProduct;
        private System.Windows.Forms.Button BtnUpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreateProductType;
        private System.Windows.Forms.Label label3;
    }
}