
namespace Neo4J_Repository.View
{
    partial class RestaurantView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantView));
            this.BtnCreateNewRestaurant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateNewRestaurant
            // 
            this.BtnCreateNewRestaurant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateNewRestaurant.BackgroundImage")));
            this.BtnCreateNewRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCreateNewRestaurant.Location = new System.Drawing.Point(150, 100);
            this.BtnCreateNewRestaurant.Name = "BtnCreateNewRestaurant";
            this.BtnCreateNewRestaurant.Size = new System.Drawing.Size(150, 150);
            this.BtnCreateNewRestaurant.TabIndex = 1;
            this.BtnCreateNewRestaurant.UseVisualStyleBackColor = true;
            this.BtnCreateNewRestaurant.Click += new System.EventHandler(this.BtnCreateNewRestaurant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create new restaurant";
            // 
            // RestaurantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreateNewRestaurant);
            this.Name = "RestaurantView";
            this.Text = "RestaurantView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateNewRestaurant;
        private System.Windows.Forms.Label label1;
    }
}