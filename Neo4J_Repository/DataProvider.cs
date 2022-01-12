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

        internal static void AddRestaurant(Restaurant newRestaurant)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(r: Restaurant {newRestaurant})")
               .WithParam("newRestaurant", newRestaurant)
               .ExecuteWithoutResults();
        }

        internal static void AddProduct(Product newProduct)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(p :Product {newProduct})")
               .WithParam("newProduct", newProduct)
               .ExecuteWithoutResults();
        }

        internal static void AddProductType(ProductType newProductType)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(t:ProductType {newProductType})")
               .WithParam("newProductType", newProductType)
               .ExecuteWithoutResults();
        }

        #endregion

        #region Relations

        public static void AddRelationProductTypeRestaurant(ProductType productType, Restaurant restaurant)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(t:ProductType)", "(s:Restaurant)")
                  .Where((ProductType t) => t.Id == productType.Id)
                  .AndWhere((Restaurant s) => s.Id == restaurant.Id)
                  .Create("(t)-[:IMA_U]->(s)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationRestaurantProductType(Restaurant restaurant, ProductType productType)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(s:Restaurant)", "(t:ProductType)")
                  .Where((Restaurant s) => s.Id == restaurant.Id)
                  .AndWhere((ProductType t) => t.Id == productType.Id)
                  .Create("(s)-[:ima_tip_proizvoda]->(t)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductProductType(Product product, ProductType productType)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(p:Product)", "(t:ProductType)")
                  .Where((Product p) => p.Id == product.Id)
                  .AndWhere((ProductType t) => t.Id == productType.Id)
                  .Create("(p)-[:ima_tip]->(t)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductTypeProduct(ProductType productType, Product product)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(t:ProductType)", "(p:Product)")
                  .Where((ProductType t) => t.Id == productType.Id)
                  .AndWhere((Product p) => p.Id == product.Id)
                  .Create("(t)-[:JE_TIP]->(p)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationProductRestaurant(Product product, Restaurant restaurant)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(p:Product)", "(r:Restaurant)")
                  .Where((Product p) => p.Id == product.Id)
                  .AndWhere((Restaurant r) => r.Id == restaurant.Id)
                  .Create("(p)-[:pripada_skladistu]->(r)")
                  .ExecuteWithoutResults();
        }

        public static void AddRelationRestaurantProduct(Restaurant restaurant, Product product)
        {
            ConnectToTheBase();
            client.Cypher
                  .Match("(s:Restaurant)", "(p:Product)")
                  .Where((Restaurant s) => s.Id == restaurant.Id)
                  .AndWhere((Product p) => p.Id == product.Id)
                  .Create("(s)-[:ima_proizvod_kolicina]->(p)")
                  .ExecuteWithoutResults();
        }

        #endregion

        #region Get

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

        public static List<ProductType> GetProductType()
        {
            ConnectToTheBase();
            List<ProductType> productTypes =
             client.Cypher
                     .Match("(tip:ProductType)")
                     .Return(tip => tip.As<ProductType>())
                     .Results.ToList();
            return productTypes;
        }

        public static List<ProductType> GetProductType1(string name)
        {
            ConnectToTheBase();
            return client.Cypher.Match("(s:ProductType)")
                .Where("s.name={name}").
                WithParam("name", name).
                Return(s => s.As<ProductType>()).Results.ToList();
        }

        #endregion
    }
}
