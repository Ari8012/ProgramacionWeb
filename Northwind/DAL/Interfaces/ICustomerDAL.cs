using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace DAL.Interfaces
{
    public class ICustomerDAL : IDALGenerico<Customer>
    {
        public bool Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
