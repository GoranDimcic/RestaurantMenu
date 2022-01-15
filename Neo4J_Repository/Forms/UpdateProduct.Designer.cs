
namespace Neo4J_Repository.Forms
{
    partial class UpdateProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRestaurant = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // comboBoxRestaurant
            // 
            this.comboBoxRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRestaurant.FormattingEnabled = true;
            this.comboBoxRestaurant.Location = new System.Drawing.Point(150, 22);
            this.comboBoxRestaurant.Name = "comboBoxRestaurant";
            this.comboBoxRestaurant.Size = new System.Drawing.Size(130, 28);
            this.comboBoxRestaurant.TabIndex = 3;
            this.comboBoxRestaurant.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRestaurant_SelectedIndexChanged);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(150, 77);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(130, 28);
            this.comboBoxProduct.TabIndex = 4;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(150, 132);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(130, 26);
            this.TxtPrice.TabIndex = 5;
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Location = new System.Drawing.Point(165, 180);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(100, 40);
            this.BtnUpdateProduct.TabIndex = 6;
            this.BtnUpdateProduct.Text = "Update product";
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxRestaurant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRestaurant;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnUpdateProduct;
    }
}