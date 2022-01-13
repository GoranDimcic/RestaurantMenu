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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void BtnCreateNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.ShowDialog();
        }

        private void BtnAddProductType_Click(object sender, EventArgs e)
        {
            AddProductType form = new AddProductType();
            form.ShowDialog();
        }

        private void BtnAddProductToRestaurant_Click(object sender, EventArgs e)
        {
            UpdateProductToRestaurant form = new UpdateProductToRestaurant();
            form.ShowDialog();
        }
    }
}
