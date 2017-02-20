using MongoDB.Bson;

namespace TypedDocs.Domain.Model
{
    public class Person
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
