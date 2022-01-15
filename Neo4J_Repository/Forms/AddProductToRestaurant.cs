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
    public partial class AddProductToRestaurant : Form
    {
        public Restaurant restaurant;

        public AddProductToRestaurant()
        {
            InitializeComponent();
            FillRestaurants();
            FillProducts();
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

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            restaurant = DataProvider.GetRestaurant1(comboBoxRestaurant.SelectedItem.ToString());

            List<String> selected = new List<String>();
            foreach (String s in checkedListBoxProducts.CheckedItems)
            {
                selected.Add(s);
                Product p = DataProvider.GetProduct(s);
                string sr = p.Name;
                restaurant.ProductLists.Add(sr);
                restaurant.Products.Add(p);

                DataProvider.AddRelationProductRestaurant(p, restaurant);
                DataProvider.AddRelationRestaurantProduct(restaurant, p);

                DialogResult = DialogResult.OK;
            }
        }

        public void FillProducts()
        {
            List<Product> products = DataProvider.GetProducts();

            foreach (Product product in products)
            {
                checkedListBoxProducts.Items.Add(product.Name);
            }
        }
    }
}
