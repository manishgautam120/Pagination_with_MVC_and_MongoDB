using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Pagination_with_MVC_and_MongoDB.Models
{
    public class UserInfo
    {
        [BsonId]     //it uses because object id is primary for ourdatabase
        public ObjectId Id { get; set; }


        [BsonElement("name")]
        public string Name { get; set; }



        [BsonElement("username")]
        public string UserName { get; set; }


        [BsonElement("email")]
        public string Email { get; set; }


    }
}