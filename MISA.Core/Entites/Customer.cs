using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entites
{
    public class Customer
    {
        /// <summary>
        /// Khách hàng
        /// </summary>
        /// 
        public Guid CustomerId { get; set; }

        public string CustomerCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int? Gender { get; set; }

        public string Address { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Guid CustomerGroupId { get; set; }

        public string DebitAmout { get; set; }

        public string CompanyTaxCode { get; set; }
        public int? IsStopFollow { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedlDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}
