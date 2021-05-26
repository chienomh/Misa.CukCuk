using MISA.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface.Infrastrure
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();

        Customer GetById(Guid customerId);

        int Insert(Customer customer);

        int Update(Customer customer, Guid customerId);

        int Delete(Guid customerId);
    }
}
