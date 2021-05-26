using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entites
{
    class CustomerGroup
    {
        public Guid CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }

        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime MyProperty { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public  string  ModifiedBy { get; set; }
    }
}
