
namespace Neo4J_Repository.Forms
{
    partial class AddProductToRestaurant
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
            this.checkedListBoxProducts = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRestaurant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkedListBoxProducts
            // 
            this.checkedListBoxProducts.CheckOnClick = true;
            this.checkedListBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxProducts.FormattingEnabled = true;
            this.checkedListBoxProducts.Location = new System.Drawing.Point(150, 80);
            this.checkedListBoxProducts.Name = "checkedListBoxProducts";
            this.checkedListBoxProducts.Size = new System.Drawing.Size(170, 130);
            this.checkedListBoxProducts.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(150, 234);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(170, 40);
            this.BtnAddProduct.TabIndex = 4;
            this.BtnAddProduct.Text = "Add product to restaurant";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Restaurant";
            // 
            // comboBoxRestaurant
            // 
            this.comboBoxRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRestaurant.FormattingEnabled = true;
            this.comboBoxRestaurant.Location = new System.Drawing.Point(150, 22);
            this.comboBoxRestaurant.Name = "comboBoxRestaurant";
            this.comboBoxRestaurant.Size = new System.Drawing.Size(170, 28);
            this.comboBoxRestaurant.TabIndex = 2;
            // 
            // AddProductToRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.comboBoxRestaurant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.checkedListBoxProducts);
            this.Controls.Add(this.label4);
            this.Name = "AddProductToRestaurant";
            this.Text = "AddProductToRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRestaurant;
    }
}