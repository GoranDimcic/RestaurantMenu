using Neo4J_Repository.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo4J_Repository.View
{
    public partial class RestaurantView : Form
    {
        public RestaurantView()
        {
            InitializeComponent();
        }

        private void BtnCreateNewRestaurant_Click(object sender, EventArgs e)
        {
            AddRestaurant form = new AddRestaurant();
            form.ShowDialog();
        }

        private void BtnAddProductTypeToRestaurant_Click(object sender, EventArgs e)
        {
            AddProductToRestaurant form = new AddProductToRestaurant();
            form.ShowDialog();
        }
    }
}
