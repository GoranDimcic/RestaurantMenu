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
    public partial class AddCustomer : Form
    {
        public Customer customer;
        public GraphClient graphClient;

        public AddCustomer()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void BtnCreateCustomer_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                customer.Name = TxtName.Text;
                customer.CreditCard = TxtCreditCard.Text;
                customer.Bills = new List<Bill>();

                List<Customer> customers = DataProvider.GetCustomers();
                int max = -1;

                foreach (Customer customer in customers)
                {
                    if (int.Parse(customer.Id) > max)
                        max = int.Parse(customer.Id);
                }

                customer.Id = (max + 1).ToString();
                DataProvider.AddCustomer(customer);

                DialogResult = DialogResult.OK;
                CreateOrder form = new CreateOrder(customer);
                form.ShowDialog();
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        private bool Validation()
        {
            if (TxtName.Text.Equals("") || TxtCreditCard.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void EnterClick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnCreateCustomer.PerformClick();
        }
    }
}
