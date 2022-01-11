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

        #region Restaurant

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

        internal static void AddRestaurant(Restaurant newRestaurant)
        {
            ConnectToTheBase();
            client.Cypher
               .Create("(r: Restaurant {newRestaurant})")
               .WithParam("newRestaurant", newRestaurant)
               .ExecuteWithoutResults();
        }

        #endregion
    }
}
