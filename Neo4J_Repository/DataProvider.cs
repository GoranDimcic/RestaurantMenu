using Neo4J_Repository.Domain;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4J_Repository
{
    public class DataProvider
    {
        public static GraphClient client;

        public static void ConnectToTheBase()
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "edukacija");
            try
            {
                client.Connect();
            }
            catch (Exception)
            {
                //MessageBox.Show(exc.Message);
            }
        }

        #region Add

        internal static void AddProductType(ProductType newProductType)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(pt:ProductType {newProductType})")
               .WithParam("newProductType", newProductType)
               .ExecuteWithoutResults();
        }

        internal static void AddProduct(Product newProduct)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(p:Product {newProduct})")
               .WithParam("newProduct", newProduct)
               .ExecuteWithoutResults();
        }

        internal static void AddRestaurant(Restaurant newRestaurant)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(r:Restaurant {newRestaurant})")
               .WithParam("newRestaurant", newRestaurant)
               .ExecuteWithoutResults();
        }

        internal static void AddCustomer(Customer newCustomer)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(c:Customer {newCustomer})")
               .WithParam("newCustomer", newCustomer)
               .ExecuteWithoutResults();
        }

        internal static void AddBill(Bill newBill)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(b:Bill {newBill})")
               .WithParam("newBill", newBill)
               .ExecuteWithoutResults();
        }

        #endregion

        #region Update

        internal static Product UpdateProduct(string name, float price)
        {
            ConnectToTheBase();
            return client.Cypher.Match("(p:Product)")
                .Where("p.Name={name}").
                Set("p.Price = {price}").
                WithParam("name", name).
                WithParam("price", price).
                Return(p => p.As<Product>()).Results.FirstOrDefault();
        }

        #endregion

        #region Relations

        public static void AddRelationProductTypeRestaurant(ProductType productType, Restaurant restaurant)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(pt:ProductType)", "(r:Restaurant)")
                  .Where((ProductType pt) => pt.Id == productType.Id)
                  .AndWhere((Restaurant r) => r.Id == restaurant.Id)
                  .Create("(pt)-[:postoji]->(r)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationRestaurantProductType(Restaurant restaurant, ProductType productType)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(r:Restaurant)", "(pt:ProductType)")
                  .Where((Restaurant r) => r.Id == restaurant.Id)
                  .AndWhere((ProductType pt) => pt.Id == productType.Id)
                  .Create("(r)-[:ima_tip_proizvoda]->(pt)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductProductType(Product product, ProductType productType)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(p:Product)", "(pt:ProductType)")
                  .Where((Product p) => p.Id == product.Id)
                  .AndWhere((ProductType pt) => pt.Id == productType.Id)
                  .Create("(p)-[:ima_tip_proizvoda]->(pt)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductTypeProduct(ProductType productType, Product product)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(pt:ProductType)", "(p:Product)")
                  .Where((ProductType pt) => pt.Id == productType.Id)
                  .AndWhere((Product p) => p.Id == product.Id)
                  .Create("(pt)-[:je_tip]->(p)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductRestaurant(Product product, Restaurant restaurant)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(p:Product)", "(r:Restaurant)")
                  .Where((Product p) => p.Id == product.Id)
                  .AndWhere((Restaurant r) => r.Id == restaurant.Id)
                  .Create("(p)-[:je_na_meniju]->(r)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationRestaurantProduct(Restaurant restaurant, Product product)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(r:Restaurant)", "(p:Product)")
                  .Where((Restaurant r) => r.Id == restaurant.Id)
                  .AndWhere((Product p) => p.Id == product.Id)
                  .Create("(r)-[:ima_proizvod]->(p)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationBillRestaurant(Bill bill, Restaurant restaurant)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(b:Bill)", "(r:Restaurant)")
                  .Where((Bill b) => b.Id == bill.Id)
                  .AndWhere((Restaurant r) => r.Id == restaurant.Id)
                  .Create("(b)-[:ima_iznos_u]->(r)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationRestaurantBill(Restaurant restaurant, Bill bill)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(r:Restaurant)", "(b:Bill)")
                  .Where((Restaurant r) => r.Id == restaurant.Id)
                  .AndWhere((Bill b) => b.Id == bill.Id)
                  .Create("(r)-[:ima_iznos]->(b)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationBillCustomer(Bill bill, Customer customer)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(b:Bill)", "(c:Customer)")
                  .Where((Bill b) => b.Id == bill.Id)
                  .AndWhere((Customer c) => c.Id == customer.Id)
                  .Create("(b)-[:placa]->(c)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationCustomerBill(Customer customer, Bill bill)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(c:Customer)", "(b:Bill)")
                  .Where((Customer c) => c.Id == customer.Id)
                  .AndWhere((Bill b) => b.Id == bill.Id)
                  .Create("(c)-[:je_napravio_iznos]->(b)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationBillProduct(Bill bill, Product product)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(b:Bill)", "(p:Product)")
                  .Where((Bill b) => b.Id == bill.Id)
                  .AndWhere((Product p) => p.Id == product.Id)
                  .Create("(b)-[:ima_proizvode]->(p)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductBill(Product product, Bill bill)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(p:Product)", "(b:Bill)")
                  .Where((Product p) => p.Id == product.Id)
                  .AndWhere((Bill b) => b.Id == bill.Id)
                  .Create("(p)-[:se_nalazi_na]->(b)")
                  .ExecuteWithoutResults();
        }

        #endregion

        #region Get

        public static ProductType GetOneProductType(string name)
        {
            ConnectToTheBase();
            return client.Cypher.Match("(pt:ProductType)")
                .Where("pt.Name={name}").
                WithParam("name", name).
                Return(pt => pt.As<ProductType>()).Results.FirstOrDefault();
        }

        public static List<ProductType> GetProductType()
        {
            ConnectToTheBase();
            List<ProductType> productTypes =
             client.Cypher
                     .Match("(pt:ProductType)")
                     .Return(pt => pt.As<ProductType>())
                     .Results.ToList();
            return productTypes;
        }

        public static List<ProductType> GetProductTypes()
        {
            ConnectToTheBase();
            List<ProductType> products =
             client.Cypher
                     .Match("(pt:ProductType)")
                     .Return(pt => pt.As<ProductType>())
                     .Results.ToList();
            return products;
        }

        public static Product GetProduct(string name)
        {
            ConnectToTheBase();
            return client.Cypher.Match("(p:Product)")
                .Where("p.Name={name}").
                WithParam("name", name).
                Return(p => p.As<Product>()).Results.FirstOrDefault();
        }

        public static List<Product> GetProducts()
        {
            ConnectToTheBase();
            List<Product> products =
             client.Cypher
                     .Match("(p:Product)")
                     .Return(p => p.As<Product>())
                     .Results.ToList();
            return products;
        }

        public static List<Product> GetProducts(Restaurant restaurant)
        {
            ConnectToTheBase();
            List<Product> p = client.Cypher.Match("(prod:Product)")
                .Where("prod.Restaurant={restaurant}")
                .WithParam("restaurant", restaurant)
                .Return(prod => prod.As<Product>()).Results.ToList();
            return p;
        }

        public static Restaurant GetOneRestaurant(string name)
        {
            ConnectToTheBase();
            return client.Cypher.Match("(r:Restaurant)")
                .Where("r.Name={name}").
                WithParam("name", name).
                Return(r => r.As<Restaurant>()).Results.FirstOrDefault();
        }

        public static List<Restaurant> GetRestaurant(string restaurant)
        {
            ConnectToTheBase();
            return client.Cypher.Match("(r:Restaurant)")
                .Where("r.name={restaurant}").
                WithParam("restaurant", restaurant).
                Return(r => r.As<Restaurant>()).Results.ToList();
        }

        public static List<Restaurant> GetRestaurants()
        {
            ConnectToTheBase();
            List<Restaurant> restaurants =
             client.Cypher
                     .Match("(r:Restaurant)")
                     .Return(r => r.As<Restaurant>())
                     .Results.ToList();
            return restaurants;
        }

        public static List<Customer> GetCustomers()
        {
            ConnectToTheBase();
            List<Customer> customers =
             client.Cypher
                     .Match("(c:Customer)")
                     .Return(c => c.As<Customer>())
                     .Results.ToList();
            return customers;
        }

        public static List<Bill> GetBills()
        {
            ConnectToTheBase();
            List<Bill> bills =
             client.Cypher
                     .Match("(b:Bill)")
                     .Return(b => b.As<Bill>())
                     .Results.ToList();
            return bills;
        }

        #endregion
    }
}