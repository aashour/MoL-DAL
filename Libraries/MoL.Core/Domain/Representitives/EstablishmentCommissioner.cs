using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Laborers;
using MoL.Core.Domain.Representitives.Enums;

namespace MoL.Core.Domain.Representitives
{
    public class EstablishmentCommissioner : BaseEntity
    {
        public int FK_CommissionerTypeId { get; set; }
        public long FK_EstablishmentId { get; set; }
        public long? FK_LaborerId { get; set; }
        public int? FK_ServiceOfficeId { get; set; }
        public string AuthorizationNumber { get; set; }
        public string Source { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public System.DateTime CommissionStartDate { get; set; }
        public System.DateTime CommissionEndDate { get; set; }
        public string CommissionReason { get; set; }
        public bool? StopCommission { get; set; }
        public DateTime? StopCommissionDate { get; set; }
        public string StopCommissionReason { get; set; }
        public long? SequenceNumber { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual CommissionerType CommissionerType
        {
            get
            {
                return (CommissionerType)this.FK_CommissionerTypeId;
            }
            set
            {
                this.FK_CommissionerTypeId = (int)value;
            }
        }
        public virtual Establishment Establishment { get; set; }
        public virtual Laborer Laborer { get; set; }
        public virtual ServiceOffice ServiceOffice { get; set; }
        private ICollection<EstablishmentCommissionerService> _establishmentCommissionerServices { get; set; }
        public virtual ICollection<EstablishmentCommissionerService> EstablishmentCommissionerServices
        {
            get { return _establishmentCommissionerServices ?? (_establishmentCommissionerServices = new List<EstablishmentCommissionerService>()); }
            protected set { _establishmentCommissionerServices = value; }
        }
 
    }
}
