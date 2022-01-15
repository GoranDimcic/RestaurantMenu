using Neo4J_Repository.Domain;
using Neo4jClient;
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
    public partial class AddRestaurant : Form
    {
        public Restaurant restaurant;
        public GraphClient graphClient;

        public AddRestaurant()
        {
            restaurant = new Restaurant();
            InitializeComponent();
        }

        private void BtnCreateRestaurant_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                restaurant.Name = TxtName.Text;
                restaurant.Phone = TxtPhone.Text;
                restaurant.Address = TxtAddress.Text;
                restaurant.Products = new List<Product>();
                restaurant.ProductLists = new List<string>();

                List<Restaurant> restaurants = DataProvider.GetRestaurants();
                int max = -1;

                foreach (Restaurant restaurant in restaurants)
                {
                    if (int.Parse(restaurant.Id) > max)
                        max = int.Parse(restaurant.Id);
                }
                restaurant.Id = (max + 1).ToString();

                DataProvider.AddRestaurant(restaurant);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        public bool Validation()
        {
            if (TxtName.Text.Equals("") || TxtPhone.Text.Equals("") || TxtAddress.Text.Equals(""))
                return false;
            return true;
        }

        private void TxtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnCreateRestaurant.PerformClick();
        }

        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
