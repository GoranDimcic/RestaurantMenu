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
    public partial class AddProduct : Form
    {
        public Product product;
        public GraphClient graphClient;
        //public List<Product> Products;

        public AddProduct()
        {
            InitializeComponent();
            product = new Product();

            FillProducts();
        }

        public void FillProducts()
        {
            List<ProductType> products = DataProvider.GetProductTypes();
            List<string> d = new List<string>();
            foreach (ProductType productType in products)
            {
                d.Add(productType.Name);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s in filter)
            {
                comboBoxProductTypes.Items.Add(s);
            }
        }

        private void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                product.Name = TxtName.Text;
                product.Description = TxtDescription.Text;
                product.Weight = float.Parse(TxtWeight.Text);
                product.Price = float.Parse(TxtPrice.Text);

                List<Product> products = DataProvider.GetProducts();
                int max = -1;
                foreach (Product product in products)
                {
                    if (int.Parse(product.Id) > max)
                        max = int.Parse(product.Id);
                }

                product.Id = (max + 1).ToString();
                DataProvider.AddProduct(product);

                String type = comboBoxProductTypes.Text;
                ProductType type1 = DataProvider.GetProductType1(type);

                type1.Products = new List<Product>();
                type1.Products.Add(product);

                DataProvider.AddRelationProductProductType(product, type1);
                DataProvider.AddRelationProductTypeProduct(type1, product);
            }
            else
            {
                MessageBox.Show("You must fill all fields!");
            }
        }

        public bool Validation()
        {
            if (TxtName.Text.Equals("") || TxtWeight.Text.Equals("") || TxtPrice.Text.Equals("") || TxtDescription.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
