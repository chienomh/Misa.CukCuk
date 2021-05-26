using MISA.Core.Entites;
using MISA.Core.Interface.Infrastrure;
using MISA.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class CustomerService : ICustomerService
    {
        public int? Insert(Customer customer)
        {
            ICustomerRepository customerRepository;
            //xử lý nghiệp vụ:
            // - validate dữ liệu:
            // Kiểm tra các thông tin bắt buộc nhập:
            if (customer.CustomerCode == string.Empty)
            {
                return null;
            }
            // Nếu các thông tin đã hợp lệ -> Gửi yêu cầu lên bộ phận
            else
            {
                return 1;
            } 
            
                
        }

        public int? Update(Customer customer, Guid customerId)
        {
            return 0;
        }

        int? ICustomerService.Update(Customer customer, Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
