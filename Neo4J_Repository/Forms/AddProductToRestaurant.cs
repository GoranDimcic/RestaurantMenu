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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            restaurant = DataProvider.GetRestaurant1(comboBox2.SelectedItem.ToString());

            List<String> selected = new List<String>();
            foreach (String s in checkedListBox1.CheckedItems)
            {
                selected.Add(s);
                Product p = DataProvider.GetProduct(s);
                restaurant.Products.Add(p);
                //p.Restaurants.Add(restaurant);
                DataProvider.AddRelationProductRestaurant(p, restaurant);
                DataProvider.AddRelationRestaurantProduct(restaurant, p);
            }
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
                comboBox2.Items.Add(s);
            }
        }

        public void FillProducts()
        {
            List<Product> products = DataProvider.GetProducts();

            foreach (Product product in products)
            {
                checkedListBox1.Items.Add(product.Name);
            }
        }
    }
}
