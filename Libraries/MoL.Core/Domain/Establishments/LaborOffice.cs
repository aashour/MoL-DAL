using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Representitives;
using MoL.Core.Domain.Transactions;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Establishments
{
    public class LaborOffice : BaseEntity
    {
        public string Name { get; set; }
        public short? FK_BankId { get; set; }
        public long? AccountNumber { get; set; }
        public double? Balance { get; set; }
        public int? FK_CityId { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string ZipCode { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string ManagerName { get; set; }
        public bool? IsActive { get; set; }
        public short? FK_ZoneId { get; set; }
        public string BenChapterNo { get; set; }
        public string BenBranchNo { get; set; }
        public string BenSectionNo { get; set; }
        public string BenSequenceNo { get; set; }
        public string BenSubDepartmentsCount { get; set; }
        public string BenSubSectionsCount { get; set; }
        public string DepChapterNo { get; set; }
        public string DepBranchNo { get; set; }
        public string DepSectionNo { get; set; }
        public string DepSequenceNo { get; set; }
        public string DepSubDepartmentsCount { get; set; }
        public string DepSubSectionsCount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual City City { get; set; }
        public virtual Zone Zone { get; set; }

        private ICollection<Municipality> _municipalities { get; set; }

        public virtual ICollection<Municipality> Municipalities
        {
            get { return _municipalities ?? (_municipalities = new List<Municipality>()); }
            protected set { _municipalities = value; }
        }

        private ICollection<Agent> _agents { get; set; }

        public virtual ICollection<Agent> Agents
        {
            get { return _agents ?? (_agents = new List<Agent>()); }
            protected set { _agents = value; }
        }

        private ICollection<EmployeeUser> _employeeUsers { get; set; }
        public virtual ICollection<EmployeeUser> EmployeeUsers
        {
            get { return _employeeUsers ?? (_employeeUsers = new List<EmployeeUser>()); }
            protected set { _employeeUsers = value; }
        }

        private ICollection<Laborer> _laborers { get; set; }
        public virtual ICollection<Laborer> Laborers
        {
            get { return _laborers ?? (_laborers = new List<Laborer>()); }
            protected set { _laborers = value; }
        }
        private ICollection<Owner> _owners { get; set; }
        public virtual ICollection<Owner> Owners
        {
            get { return _owners ?? (_owners = new List<Owner>()); }
            protected set { _owners = value; }
        }
        private ICollection<Srv_Transaction> _srv_Transactions { get; set; }
        public virtual ICollection<Srv_Transaction> Srv_Transactions
        {
            get { return _srv_Transactions ?? (_srv_Transactions = new List<Srv_Transaction>()); }
            protected set { _srv_Transactions = value; }
        }
        private ICollection<UnifiedNumber> _unifiedNumbers { get; set; }
        public virtual ICollection<UnifiedNumber> UnifiedNumbers
        {
            get { return _unifiedNumbers ?? (_unifiedNumbers = new List<UnifiedNumber>()); }
            protected set { _unifiedNumbers = value; }
        }
        private ICollection<User> _users { get; set; }
        public virtual ICollection<User> Users
        {
            get { return _users ?? (_users = new List<User>()); }
            protected set { _users = value; }
        }
    }
}
