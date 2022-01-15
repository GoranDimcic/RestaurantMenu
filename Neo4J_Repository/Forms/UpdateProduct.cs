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

        public void FillProducts()
        {
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

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Product product = DataProvider.GetProduct(comboBoxProduct.SelectedItem.ToString());
                string str = product.Name;
                float price = float.Parse(TxtPrice.Text);

                DataProvider.UpdateProduct(str, price);

                MessageBox.Show("New price for " + str + " is " + price);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        public bool Validation()
        {
            if (TxtPrice.Text.Equals(""))
                return false;
            return true;
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
