using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Establishments;
using MoL.Core.Domain.Establishments.Enums;
using MoL.Core.Domain.Transactions.Enums;
using MoL.Core.Domain.Users;

namespace MoL.Core.Domain.Transactions
{
    public class Srv_Transaction : BaseEntity
    {
        public int FK_Service_ServiceId { get; set; }
        public string TransactionNumber { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal TransactionFees { get; set; }
        public long? FK_EstablishmentId { get; set; }
        public int? FK_LaborOfficeId { get; set; }
        public long? FK_RequesterId { get; set; }
        public int? Fk_RequesterTypeId { get; set; }
        public string OtherRequester { get; set; }
        public decimal? BillNumber { get; set; }
        public DateTime? StatusLastModificationDate { get; set; }
        public long? FK_UserID { get; set; }
        public int? FK_PayementTypeID { get; set; }
        public string RecieptNumber { get; set; }
        public long? FK_CreatedByUserId { get; set; }

        public int? FK_Service_LastServiceStatusId { get; set; }

        //public virtual Srv_Transaction Srv_Transaction { get; set; }
        public virtual User User { get; set; }

        public virtual Establishment Establishment { get; set; }

        public virtual LaborOffice LaborOffice { get; set; }

        public virtual Srv_ServiceStatus LastServiceStatus
        {
            get
            {
                return (Srv_ServiceStatus)this.FK_Service_LastServiceStatusId;
            }
            set
            {
                this.FK_Service_LastServiceStatusId = (int)value;
            }
        }

        public virtual PayementType PayementType
        {
            get
            {
                return (PayementType)this.FK_PayementTypeID;
            }
            set
            {
                this.FK_PayementTypeID = (int)value;
            }
        }


        public virtual RequesterType RequesterType
        {
            get
            {
                return (RequesterType)this.Fk_RequesterTypeId;
            }
            set
            {
                this.Fk_RequesterTypeId = (int)value;
            }
        }
        public virtual Service Service
        {
            get
            {
                return (Service)this.FK_Service_ServiceId;
            }
            set
            {
                this.FK_Service_ServiceId = (int)value;
            }
        }

        private ICollection<ChangeJobDescriptionRequest> _changeJobDescriptionRequests { get; set; }
        public virtual ICollection<ChangeJobDescriptionRequest> ChangeJobDescriptionRequests
        {
            get { return _changeJobDescriptionRequests ?? (_changeJobDescriptionRequests = new List<ChangeJobDescriptionRequest>()); }
            protected set { _changeJobDescriptionRequests = value; }
        }

        private ICollection<ChangeWorkStatusRequest> _changeWorkStatusRequests { get; set; }
        public virtual ICollection<ChangeWorkStatusRequest> ChangeWorkStatusRequests
        {
            get { return _changeWorkStatusRequests ?? (_changeWorkStatusRequests = new List<ChangeWorkStatusRequest>()); }
            protected set { _changeWorkStatusRequests = value; }
        }

        private ICollection<Srv_TransactionOwner> _srv_TransactionOwners { get; set; }
        public virtual ICollection<Srv_TransactionOwner> Srv_TransactionOwners
        {
            get { return _srv_TransactionOwners ?? (_srv_TransactionOwners = new List<Srv_TransactionOwner>()); }
            protected set { _srv_TransactionOwners = value; }
        }

        private ICollection<WorkPermit> _workPermits { get; set; }
        public virtual ICollection<WorkPermit> WorkPermits
        {
            get { return _workPermits ?? (_workPermits = new List<WorkPermit>()); }
            protected set { _workPermits = value; }
        }
    }
}
