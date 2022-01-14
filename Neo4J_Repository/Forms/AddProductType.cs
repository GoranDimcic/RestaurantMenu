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

                List<ProductType> productTypes = DataProvider.GetProductTypes();
                int max = -1;
                foreach (ProductType productType in productTypes)
                {
                    if (int.Parse(productType.Id) > max)
                        max = int.Parse(productType.Id);
                }

                productType.Id = (max + 1).ToString();
                DataProvider.AddProductType(productType);
            }
            else
            {
                MessageBox.Show("You must fill all fields!");
            }
        }

        public bool Validation()
        {
            if (TxtName.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
