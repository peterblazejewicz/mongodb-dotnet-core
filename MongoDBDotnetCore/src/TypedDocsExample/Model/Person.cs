using MongoDB.Bson;

namespace TypedDocsExample.Model
{
    public class Person
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
