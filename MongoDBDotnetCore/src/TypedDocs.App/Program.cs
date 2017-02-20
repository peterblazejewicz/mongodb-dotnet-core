using System;
using MongoDB.Driver;
using TypedDocs.Domain.Model;

namespace TypedDocs.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<Person>("bar");
            collection.InsertOne(new Person { Name = "Jack" });
            var list = collection.Find(x => x.Name == "Jack")
                .ToList();
            foreach (var person in list)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
