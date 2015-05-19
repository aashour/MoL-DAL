using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Users;
 
namespace MoL.Core.Domain.Log
{
    public class AuditTrailInfo : BaseEntity
    {
        public Nullable<long> Property_Id { get; set; }
        public string Logical_Id { get; set; }
        public DateTime? Update_Time { get; set; }
        public Nullable<long> Updated_By { get; set; }
        public string New_Value { get; set; }
        public string Old_Value { get; set; }

        public virtual AuditTrailProperty AuditTrailProperty { get; set; }
        public virtual User MOL_User { get; set; }
    }
}
