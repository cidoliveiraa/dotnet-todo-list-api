using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_todo_list_api.Models
{
  public class Task
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }    
    [BsonElement("status")]
    public string Status { get; set; }
    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("created_date")]
    public DateTime CreatedDate { get; set; }
  }
}