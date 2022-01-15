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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();

            FillRestaurants();
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {


            DialogResult = DialogResult.OK;
        }

        public void FillRestaurants()
        {
            List<Restaurant> restaurants = DataProvider.GetRestaurants();
            List<string> d = new List<string>();

            foreach (Restaurant restaurant in restaurants)
            {
                d.Add(restaurant.Name);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s in filter)
            {
                comboBoxRestaurant.Items.Add(s);
            }
        }

        private void ComboBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProducts();
        }

        public void FillProducts()
        {
            //Restaurant restaurant = DataProvider.GetRestaurant1(comboBoxRestaurant.SelectedItem.ToString());

            List<Product> products = DataProvider.GetProducts();
            List<string> d = new List<string>();

            foreach (Product product in products)
            {
                d.Add(product.Name);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s in filter)
            {
                comboBoxProduct.Items.Add(s);
            }
        }
    }
}
