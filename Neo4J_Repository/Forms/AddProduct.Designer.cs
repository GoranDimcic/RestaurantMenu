
namespace Neo4J_Repository.Forms
{
    partial class AddProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnCreateCustomer = new System.Windows.Forms.Button();
            this.comboBoxProductTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type of product";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(150, 22);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 26);
            this.TxtName.TabIndex = 7;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(150, 67);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(130, 26);
            this.TxtDescription.TabIndex = 8;
            // 
            // TxtWeight
            // 
            this.TxtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWeight.Location = new System.Drawing.Point(150, 112);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(130, 26);
            this.TxtWeight.TabIndex = 9;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(150, 157);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(130, 26);
            this.TxtPrice.TabIndex = 10;
            // 
            // BtnCreateCustomer
            // 
            this.BtnCreateCustomer.Location = new System.Drawing.Point(165, 250);
            this.BtnCreateCustomer.Name = "BtnCreateCustomer";
            this.BtnCreateCustomer.Size = new System.Drawing.Size(100, 40);
            this.BtnCreateCustomer.TabIndex = 13;
            this.BtnCreateCustomer.Text = "Create";
            this.BtnCreateCustomer.UseVisualStyleBackColor = true;
            this.BtnCreateCustomer.Click += new System.EventHandler(this.BtnCreateProduct_Click);
            // 
            // comboBoxProductTypes
            // 
            this.comboBoxProductTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductTypes.FormattingEnabled = true;
            this.comboBoxProductTypes.Location = new System.Drawing.Point(150, 202);
            this.comboBoxProductTypes.Name = "comboBoxProductTypes";
            this.comboBoxProductTypes.Size = new System.Drawing.Size(130, 28);
            this.comboBoxProductTypes.TabIndex = 15;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.comboBoxProductTypes);
            this.Controls.Add(this.BtnCreateCustomer);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnCreateCustomer;
        private System.Windows.Forms.ComboBox comboBoxProductTypes;
    }
}