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
    public partial class AddProductType : Form
    {
        public ProductType productType;
        public GraphClient graphClient;

        public AddProductType()
        {
            InitializeComponent();
            productType = new ProductType();
        }

        private void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                productType.Name = TxtName.Text;
                productType.Description = TxtDescription.Text;
                productType.Restaurants = new List<Restaurant>();

                List<ProductType> productTypes = DataProvider.GetProductType();
                int max = -1;
                foreach (ProductType productType in productTypes)
                {
                    if (int.Parse(productType.Id) > max)
                        max = int.Parse(productType.Id);
                }
                productType.Id = (max + 1).ToString();
                DataProvider.AddProductType(productType);

                if (DataProvider.GetRestaurant(TxtRestaurant.Text).Count == 0)
                {
                    Restaurant r = new Restaurant
                    {
                        Name = TxtRestaurant.Text,
                    };

                    int m = -1;
                    foreach (Restaurant res in DataProvider.GetRestaurants())
                    {
                        if (int.Parse(res.Id) > m)
                            m = int.Parse(res.Id);
                    }
                    r.Id = (m + 1).ToString();
                    DataProvider.AddRestaurant(r);
                    productType.Restaurants.Add(r);
                    DataProvider.AddRelationProductTypeRestaurant(productType, r);
                    DataProvider.AddRelationRestaurantProductType(r, productType);
                }
                else
                {
                    DataProvider.AddRelationProductTypeRestaurant(productType, DataProvider.GetRestaurant(TxtRestaurant.Text)[0]);
                    DataProvider.AddRelationRestaurantProductType(DataProvider.GetRestaurant(TxtRestaurant.Text)[0], productType);
                }

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        public bool Validation()
        {
            if (TxtName.Text.Equals("") || TxtDescription.Text.Equals("") || TxtRestaurant.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
