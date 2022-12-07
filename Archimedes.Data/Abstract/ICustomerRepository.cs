using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<Customer> GetCustomerAll();
        Customer GetCustomerById(int id);
    }
}
