using Neo4J_Repository.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo4J_Repository.Forms
{
    public partial class UpdateProductToRestaurant : Form
    {
        public UpdateProductToRestaurant()
        {
            InitializeComponent();
            FillRestaurants();
        }

        public void FillRestaurants()
        {
            List<Product> products = DataProvider.GetProducts();
            List<string> d = new List<string>();
            foreach (Product product in products)
            {
                d.Add(product.RestaurantName);
            }

            List<string> filter = d.Distinct().ToList();
            foreach (string s in filter)
            {
                comboBoxRestaurant.Items.Add(s);
            }
        }

        public void FillProducts(string restaurant)
        {
            List<String> d = new List<string>();
            List<Product> products = DataProvider.GetProducts();
            foreach (Product product in products)
            {
                if (product.RestaurantName == restaurant)
                {
                    d.Add(product.Name);
                }
            }

            List<string> filter = d.Distinct().ToList();
            foreach (string e in filter)
            {
                comboBoxPorduct.Items.Add(e);
            }
        }

        private void ComboBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPorduct.Items.Clear();
            FillProducts(comboBoxRestaurant.Text);
        }

        private void BtnUpdateProductToRestaurant_Click(object sender, EventArgs e)
        {
            Product product = DataProvider.GetProducts(comboBoxRestaurant.Text.ToString(), comboBoxPorduct.Text.ToString())[0];
            product.Quantity += int.Parse(TxtQuantity.Text);
            DataProvider.UpdateProduct(product);

            DialogResult = DialogResult.Cancel;
        }
    }
}
