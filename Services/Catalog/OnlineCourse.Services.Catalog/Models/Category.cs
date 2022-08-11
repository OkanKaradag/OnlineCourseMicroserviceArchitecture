using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OnlineCourse.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // for string Id storage
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
