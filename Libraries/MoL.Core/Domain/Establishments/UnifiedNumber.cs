using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments.Enums;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Representitives;

namespace MoL.Core.Domain.Establishments
{
    public class UnifiedNumber : BaseEntity
    {
        public int FK_LaborOfficeId { get; set; }
        public long SequenceNumber { get; set; }
        public int? FK_EstablishmentTypeId { get; set; }
        public short FK_NationalityId { get; set; }
        public int? FK_LawRepresentationId { get; set; }
        public string SevenHundredNumber { get; set; }
        public int? FK_OwnerId { get; set; }
        public long? CommercialRecordSequenceNumber { get; set; }
        public long? FK_FirstEstablishment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EstablishmentType EstablishmentType
        {
            get
            {
                return (EstablishmentType)this.FK_EstablishmentTypeId;
            }
            set
            {
                this.FK_EstablishmentTypeId = (int)value;
            }
        }
        public virtual LawRepresentation LawRepresentation { get; set; }
        public virtual Nationality Nationality { get; set; }        
        public virtual LaborOffice LaborOffice { get; set; }
        public virtual Owner Owner { get; set; }

        private ICollection<Establishment> _establishments { get; set; }
        public virtual ICollection<Establishment> Establishments
        {
            get { return _establishments ?? (_establishments = new List<Establishment>()); }
            protected set { _establishments = value; }
        }
    }
}
