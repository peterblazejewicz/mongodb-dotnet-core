using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace UntypedDocsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // you need to use IP for connection on OS X
            // otherwise timeout is kicking in
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("bar");
            collection.InsertOne(new BsonDocument("Name", "Jack"));
            var list = collection.Find(new BsonDocument("Name", "Jack"))
              .ToList();
            foreach (var document in list)
            {
                Console.WriteLine(document["Name"]);
            }
            Console.WriteLine("Closing ...");
        }
    }
}
