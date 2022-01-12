
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRestaurant = new System.Windows.Forms.ComboBox();
            this.comboBoxPorduct = new System.Windows.Forms.ComboBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnUpdateProductToRestaurant = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
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
            // comboBoxPorduct
            // 
            this.comboBoxPorduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorduct.FormattingEnabled = true;
            this.comboBoxPorduct.Location = new System.Drawing.Point(150, 77);
            this.comboBoxPorduct.Name = "comboBoxPorduct";
            this.comboBoxPorduct.Size = new System.Drawing.Size(130, 28);
            this.comboBoxPorduct.TabIndex = 4;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.Location = new System.Drawing.Point(150, 137);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(130, 26);
            this.TxtQuantity.TabIndex = 5;
            // 
            // BtnUpdateProductToRestaurant
            // 
            this.BtnUpdateProductToRestaurant.Location = new System.Drawing.Point(165, 175);
            this.BtnUpdateProductToRestaurant.Name = "BtnUpdateProductToRestaurant";
            this.BtnUpdateProductToRestaurant.Size = new System.Drawing.Size(100, 40);
            this.BtnUpdateProductToRestaurant.TabIndex = 15;
            this.BtnUpdateProductToRestaurant.Text = "Update";
            this.BtnUpdateProductToRestaurant.UseVisualStyleBackColor = true;
            this.BtnUpdateProductToRestaurant.Click += new System.EventHandler(this.BtnUpdateProductToRestaurant_Click);
            // 
            // AddProductToRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.BtnUpdateProductToRestaurant);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.comboBoxPorduct);
            this.Controls.Add(this.comboBoxRestaurant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductToRestaurant";
            this.Text = "AddProductToRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRestaurant;
        private System.Windows.Forms.ComboBox comboBoxPorduct;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button BtnUpdateProductToRestaurant;
    }
}