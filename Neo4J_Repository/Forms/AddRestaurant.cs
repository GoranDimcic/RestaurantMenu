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

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (this.Validation())
            {
                restaurant.Name = TxtName.Text;
                restaurant.Address = TxtAddress.Text;
                restaurant.Phone = TxtPhone.Text;

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
            if (TxtName.Text.Equals("") || TxtAddress.Text.Equals("") || TxtPhone.Text.Equals(""))
                return false;
            return true;
        }

        private void TxtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnCreate.PerformClick();
        }
    }
}
