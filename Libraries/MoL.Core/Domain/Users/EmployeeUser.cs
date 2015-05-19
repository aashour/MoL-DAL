using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Users
{
    public class EmployeeUser : BaseEntity
    {
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public DateTime? ExpiryEndDate { get; set; }
        public int? LaborOfficeId { get; set; }
        public int? JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual LaborOffice LaborOffice { get; set; }
        public virtual User User { get; set; }
    }
}
