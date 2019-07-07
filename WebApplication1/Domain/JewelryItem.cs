using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain
{
    public class JewelryItem
    {
        /// Unique identifier
        /// </summary>
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Jewelry item name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Jewelry price
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Image URL
        /// </summary>
        public string Url { get; set; }
    }
}
