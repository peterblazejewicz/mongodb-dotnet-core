using MongoDB.Bson;

namespace TypedDocs.App.Model
{
    public class Person
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
