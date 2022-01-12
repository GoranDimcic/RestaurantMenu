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

        public AddProduct()
        {
            InitializeComponent();
            product = new Product();
        }

        private void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                product.Name = TxtName.Text;
                product.Weight = float.Parse(TxtWeight.Text);
                product.Price = float.Parse(TxtPrice.Text);
                product.Quantity = int.Parse(TxtQuantity.Text);

                List<Product> products = DataProvider.GetProducts();
                int max = -1;
                foreach (Product product in products)
                {
                    if (int.Parse(product.Id) > max)
                        max = int.Parse(product.Id);
                }

                product.Id = (max + 1).ToString();
                product.RestaurantName = TxtRestaurant.Text;
                DataProvider.AddProduct(product);

                if (DataProvider.GetProductType1(TxtType.Text).Count == 0)
                {
                    ProductType productType = new ProductType
                    {
                        Name = TxtType.Text,
                    };

                    int m = -1;
                    foreach (ProductType pt in DataProvider.GetProductType())
                    {
                        if (int.Parse(pt.Id) > m)
                            m = int.Parse(pt.Id);
                    }

                    productType.Id = (m + 1).ToString();
                    DataProvider.AddProductType(productType);
                    product.ProductType = productType;
                    DataProvider.AddRelationProductProductType(product, productType);
                    DataProvider.AddRelationProductTypeProduct(productType, product);
                }
                else
                {
                    product.ProductType = DataProvider.GetProductType1(TxtType.Text)[0];
                    DataProvider.AddRelationProductProductType(product, DataProvider.GetProductType1(TxtType.Text)[0]);
                    DataProvider.AddRelationProductTypeProduct(DataProvider.GetProductType1(TxtType.Text)[0], product);
                }

                if (DataProvider.GetRestaurant(TxtRestaurant.Text).Count == 0)
                {
                    Restaurant res = new Restaurant
                    {
                        Name = TxtRestaurant.Text,
                    };

                    int m = -1;
                    foreach (Restaurant r in DataProvider.GetRestaurants())
                    {
                        if (int.Parse(r.Id) > m)
                            m = int.Parse(r.Id);
                    }
                    res.Id = (m + 1).ToString();


                    DataProvider.AddRestaurant(res);
                    product.RestaurantName = TxtRestaurant.Text;

                    DataProvider.AddRelationProductRestaurant(product, res);
                    DataProvider.AddRelationRestaurantProduct(res, product);
                }
                else
                {
                    product.RestaurantName = TxtRestaurant.Text;
                    product.Restaurant = DataProvider.GetRestaurant(TxtRestaurant.Text)[0];
                    DataProvider.AddRelationProductRestaurant(product, DataProvider.GetRestaurant(TxtRestaurant.Text)[0]);
                    DataProvider.AddRelationRestaurantProduct(DataProvider.GetRestaurant(TxtRestaurant.Text)[0], product);
                }

                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You must fill all fields!");
            }
        }

        public bool Validation()
        {
            if (TxtName.Text.Equals("") || TxtPrice.Text.Equals("") || TxtQuantity.Text.Equals("") || TxtRestaurant.Text.Equals("") || TxtType.Text.Equals("") || TxtWeight.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
