using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IJewelryRepositorycs
    {
        IEnumerable<JewelryItem> GetItems();
    }
}
