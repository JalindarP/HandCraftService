using Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{   
    public class DbContext
    {
        private readonly IMongoDatabase _database;
        public DbContext(string connectionString, string databaseName)
        {
            IMongoClient client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<JewelryItem> JewelryItem
        {
            get
            {
                return _database.GetCollection<JewelryItem>("pictures");
            }
        }
    }
}
