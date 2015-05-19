using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Users.Enums;

namespace MoL.Core.Domain.Users
{
    public class Employee : BaseEntity
    {
        public long? FK_UserId { get; set; }
        public int? FK_EmployeeTypeId { get; set; }
        public int? FK_EmployeeAccountStatusId { get; set; }
        public string EmploymentNumber { get; set; }
        public string EmploymentName { get; set; }

        public virtual EmployeeAccountStatus UserType
        {
            get
            {
                return (EmployeeAccountStatus)this.FK_EmployeeAccountStatusId;
            }
            set
            {
                this.FK_EmployeeAccountStatusId = (int)value;
            }
        }
        public virtual EmployeeType EmployeeType
        {
            get
            {
                return (EmployeeType)this.FK_EmployeeTypeId;
            }
            set
            {
                this.FK_EmployeeTypeId = (int)value;
            }
        }
        public virtual User User { get; set; }
    }
}
