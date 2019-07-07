using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using MongoDB.Driver;
using Repository.Contracts;

namespace Repository.Implementation
{
    public class JewelryRepository : IJewelryRepositorycs
    {
        private readonly DbContext _dbContext;

        public JewelryRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<JewelryItem> GetItems()
        {
            try
            {
                var response = _dbContext.JewelryItem.AsQueryable()
                     .ToList();
                return response;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<JewelryItem>();
            }
        }
    }
}
