using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace POC_Leave_Model
{
    public enum Role
    {
        DEV=0,
        QA=1
    }
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string EmpId { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Role Role { get; set; }
        public string TeamName { get; set; }
        public string Password { get; set; }
        public Leave[] Leave { get; set; }
    }
}
