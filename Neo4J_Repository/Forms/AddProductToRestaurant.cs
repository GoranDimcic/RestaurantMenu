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

        public void FillProducts()
        {
            List<Product> products = DataProvider.GetProducts();

            foreach (Product product in products)
            {
                checkedListBoxProducts.Items.Add(product.Name);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            restaurant = DataProvider.GetOneRestaurant(comboBoxRestaurant.SelectedItem.ToString());

            foreach (String s in checkedListBoxProducts.CheckedItems)
            {
                Product product = DataProvider.GetProduct(s);
                string str = product.Name;
                restaurant.ProductLists.Add(str);
                restaurant.Products.Add(product);

                DataProvider.AddRelationProductRestaurant(product, restaurant);
                DataProvider.AddRelationRestaurantProduct(restaurant, product);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
