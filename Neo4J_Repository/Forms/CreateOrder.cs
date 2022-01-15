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
    public partial class CreateOrder : Form
    {
        public Customer Customer;
        public Restaurant Restaurant;
        public Bill bill;
        public CreateOrder(Customer customer)
        {
            Customer = customer;
            Restaurant = new Restaurant();
            bill = new Bill();

            InitializeComponent();
            FillRestaurants();
        }

        public void FillRestaurants()
        {
            List<Restaurant> restaurants = DataProvider.GetRestaurants();
            List<string> d = new List<string>();
            foreach (Restaurant restaurant in restaurants)
            {
                d.Add(restaurant.Name);
            }

            List<string> filter = d.Distinct().ToList();

            foreach (string s in filter)
            {
                comboBoxRestaurants.Items.Add(s);
            }
        }

        private void ComboBoxRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListProducts();
        }

        public void FillListProducts()
        {
            Restaurant = DataProvider.GetOneRestaurant(comboBoxRestaurants.SelectedItem.ToString());

            List<string> products = new List<string>();
            products = Restaurant.ProductLists;

            foreach (String product in products)
            {
                Product prod = DataProvider.GetProduct(product);
                checkedListBoxProducts.Items.Add(prod.Name);
            }
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            Restaurant = DataProvider.GetOneRestaurant(comboBoxRestaurants.SelectedItem.ToString());

            bill.Date = DateTime.Now;
            foreach (String s in checkedListBoxProducts.CheckedItems)
            {
                bill.Products.Add(s);
                Product p = DataProvider.GetProduct(s);
                float price = p.Price;
                bill.TotalPrice += price;
            }

            List<Bill> bills = DataProvider.GetBills();
            int max = -1;

            foreach (Bill bill in bills)
            {
                if (int.Parse(bill.Id) > max)
                    max = int.Parse(bill.Id);
            }

            bill.Id = (max + 1).ToString();
            bill.NumberBill = (max + 1).ToString();

            DataProvider.AddBill(bill);
            Restaurant.BillLists.Add(bill.Id);

            DataProvider.AddRelationRestaurantBill(Restaurant, bill);
            DataProvider.AddRelationBillRestaurant(bill, Restaurant);

            DataProvider.AddRelationCustomerBill(Customer, bill);
            DataProvider.AddRelationBillCustomer(bill, Customer);

            foreach (String s in checkedListBoxProducts.CheckedItems)
            {
                Product product = DataProvider.GetProduct(s);

                DataProvider.AddRelationBillProduct(bill, product);
                DataProvider.AddRelationProductBill(product, bill);
            }

            CreateBill form = new CreateBill(bill, Restaurant, Customer);
            form.ShowDialog();

            DialogResult = DialogResult.OK;
        }
    }
}
