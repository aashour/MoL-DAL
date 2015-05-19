using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Representitives
{
    public class Owner : BaseEntity
    {
        public string Name { get; set; }
        public Nullable<short> FK_NationalityId { get; set; }
        public string IdNo { get; set; }
        public DateTime? IdExpiryDate { get; set; }
        public string IdSource { get; set; }
        public int? FK_GenderId { get; set; }
        public int FK_CityId { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string ZipCode { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public int? FK_CurrentLaborOfficeId { get; set; }
        public bool? UpdatedByMOI { get; set; }
        public string MOIName { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual Gender Gender
        {
            get
            {
                return (Gender)this.FK_GenderId;
            }
            set
            {
                this.FK_GenderId = (int)value;
            }
        }
        public virtual City City { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual LaborOffice LaborOffice { get; set; }
        private ICollection<UnifiedNumber> _unifiedNumbers { get; set; }
        public virtual ICollection<UnifiedNumber> UnifiedNumbers
        {
            get { return _unifiedNumbers ?? (_unifiedNumbers = new List<UnifiedNumber>()); }
            protected set { _unifiedNumbers = value; }
        }
    }
}
