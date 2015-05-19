using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Transactions
{
    public class Srv_ServicesRequestType : BaseEntity
    {
        public string FK_Service_ServiceId { get; set; }
        public string FK_Service_RequestTypeId { get; set; }

        private ICollection<Srv_ServiceFees> _srv_ServiceFees { get; set; }
        public virtual ICollection<Srv_ServiceFees> Srv_ServiceFeess
        {
            get { return _srv_ServiceFees ?? (_srv_ServiceFees = new List<Srv_ServiceFees>()); }
            protected set { _srv_ServiceFees = value; }
        }
        private ICollection<Srv_ServiceRequestTypeValidation> _srv_ServiceRequestTypeValidations { get; set; }
        public virtual ICollection<Srv_ServiceRequestTypeValidation> Srv_ServiceRequestTypeValidations
        {
            get { return _srv_ServiceRequestTypeValidations ?? (_srv_ServiceRequestTypeValidations = new List<Srv_ServiceRequestTypeValidation>()); }
            protected set { _srv_ServiceRequestTypeValidations = value; }
        }
        private ICollection<WorkPermit> _workPermits { get; set; }
        public virtual ICollection<WorkPermit> WorkPermits
        {
            get { return _workPermits ?? (_workPermits = new List<WorkPermit>()); }
            protected set { _workPermits = value; }
        }
    }
}
