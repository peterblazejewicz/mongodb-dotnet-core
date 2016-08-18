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
          var client = new MongoClient("mongodb://localhost:27017");
          var database = client.GetDatabase("test");
          var collection = database.GetCollection<BsonDocument>("bar");
          collection.InsertOneAsync(new BsonDocument("Name", "Jack"));
          var list = collection.Find(new BsonDocument("Name", "Jack")).ToList();
          Console.WriteLine(list);
          foreach(var document in list)
          {
              Console.WriteLine(document["Name"]);
          }
        }
    }
}
