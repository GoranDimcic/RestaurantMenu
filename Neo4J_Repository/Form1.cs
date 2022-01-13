using Neo4J_Repository.Forms;
using Neo4J_Repository.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo4J_Repository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRestaurant_Click(object sender, EventArgs e)
        {
            AddRestaurant form = new AddRestaurant();
            form.ShowDialog();
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            ProductView form = new ProductView();
            form.ShowDialog();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            CustomerView form = new CustomerView();
            form.ShowDialog();
        }
    }
}