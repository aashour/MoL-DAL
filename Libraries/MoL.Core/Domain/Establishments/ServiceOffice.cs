using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoL.Core.Domain.Establishments.Enums;
using MoL.Core.Domain.Lookups;
using MoL.Core.Domain.Representitives;

namespace MoL.Core.Domain.Establishments
{
    public class ServiceOffice : BaseEntity
    {
        public long FK_EstablishmentId { get; set; }
        public int FK_ServiceOfficeTypeId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? SecurityNumber { get; set; }
        public DateTime? SecurityStartDate { get; set; }
        public DateTime? SecurityEndDate { get; set; }
        public string BankName { get; set; }
        public string Notes { get; set; }
        public int? FK_LaborOfficeId { get; set; }
        public string ServiceOfficeName { get; set; }
        public short? FK_BankId { get; set; }
        public long? SequenceNumber { get; set; }

        public virtual ServiceOfficeType ServiceOfficeType
        {
            get
            {
                return (ServiceOfficeType)this.FK_ServiceOfficeTypeId;
            }
            set
            {
                this.FK_ServiceOfficeTypeId = (int)value;
            }
        }
        public virtual Bank Bank { get; set; }        
        public virtual Establishment Establishment { get; set; }

        private ICollection<CommissionerSOLaborer> _commissionerSOLaborers { get; set; }
        public virtual ICollection<CommissionerSOLaborer> CommissionerSOLaborers
        {
            get { return _commissionerSOLaborers ?? (_commissionerSOLaborers = new List<CommissionerSOLaborer>()); }
            protected set { _commissionerSOLaborers = value; }
        }
        private ICollection<EstablishmentCommissioner> _establishmentCommissioners { get; set; }
        public virtual ICollection<EstablishmentCommissioner> EstablishmentCommissioners
        {
            get { return _establishmentCommissioners ?? (_establishmentCommissioners = new List<EstablishmentCommissioner>()); }
            protected set { _establishmentCommissioners = value; }
        }
  
    }
}
