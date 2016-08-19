using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace MongoRepository
{
    /// <summary>
    /// Abstract Entity for all the BusinessEntities.
    /// </summary>
    [DataContract]
    [BsonIgnoreExtraElements(Inherited = true)]
    public abstract class Entity : IEntity<string>
    {
        /// <summary>
        /// Gets or sets the id for this object (the primary record for an entity).
        /// </summary>
        /// <value>The id for this object (the primary record for an entity).</value>
        [DataMember]
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; set; }
    }
}
