using MISA.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface.Services
{
    interface ICustomerService
    {
        int? Insert(Customer customer);
        int? Update(Customer customer, Guid customerId);
    }
}
