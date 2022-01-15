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
    public partial class CreateBill : Form
    {
        public Bill createdBill;
        public Restaurant restaurant;
        public Customer customer;

        public CreateBill(Bill bill, Restaurant restaurant, Customer customer)
        {
            createdBill = bill;
            this.restaurant = restaurant;
            this.customer = customer;
            InitializeComponent();
            BillDescription();
        }

        public void BillDescription()
        {
            TxtDate.Text = createdBill.Date.ToString();
            TxtRestaurant.Text = restaurant.Name;
            TxtTotalPrice.Text = createdBill.TotalPrice.ToString();
            TxtCustomerName.Text = customer.Name;

            foreach(string product in restaurant.ProductLists)
            {
                listBoxProducts.Items.Add(product);
            }
        }
    }
}
