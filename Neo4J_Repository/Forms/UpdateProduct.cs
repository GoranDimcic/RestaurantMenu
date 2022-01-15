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

            FillProducts();
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = DataProvider.GetProduct(comboBoxProduct.SelectedItem.ToString());
            string s1 = product.Name;
            float price = float.Parse(TxtPrice.Text);

            DataProvider.UpdateProduct(s1, price);

            MessageBox.Show("Name " + s1);
            MessageBox.Show("Nova cena = " + price);

            DialogResult = DialogResult.OK;
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
