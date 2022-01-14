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
    public partial class CreateOrder : Form
    {
        public Customer Customer;
        public Restaurant Restaurant;
        public CreateOrder(Customer customer)
        {
            Customer = customer;
            Restaurant = new Restaurant();
            InitializeComponent();
            FillComboBox();
        }

        public void FillComboBox()
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
                comboBox1.Items.Add(s);
            }
        }

        public void Fill()
        {
            Restaurant = DataProvider.GetRestaurant1(comboBox1.SelectedItem.ToString());

            List<Product> proiyvodi = new List<Product>();
            proiyvodi = Restaurant.Products;

            foreach (Product product1 in proiyvodi)
            {
                MessageBox.Show("Nesot " + product1);
            }

            List<Product> products = DataProvider.GetProducts(Restaurant);

            foreach (Product product in products)
            {
                checkedListBox1.Items.Add(product.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
