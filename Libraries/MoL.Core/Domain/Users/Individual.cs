using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Domain.Lookups;

namespace MoL.Core.Domain.Users
{
    public class Individual : BaseEntity
    {
        public long? FK_UserId { get; set; }
        public int? FK_CityId { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string ZipCode { get; set; }
        public string PostalCode { get; set; }
        public string MobileNo { get; set; }
        public string Telephone { get; set; }
        public string RelativeMobile { get; set; }
        public int? FK_DisabilityTypeId1 { get; set; }
        public int? FK_DisabilityTypeId2 { get; set; }
        public int? FK_DisabilityTypeId3 { get; set; }
        public DateTime? RegisterationDate { get; set; }
        public bool IsActive { get; set; }
        public string ActivationStatusChangeReason { get; set; }
        public bool? HasDrivingLicence { get; set; }
        public int? FK_DrivingLicenseTypeId { get; set; }
        public int? FK_DrivingLicenseSecondaryTypeId { get; set; }
        public System.DateTime LastModified { get; set; }
        public long FK_LastModifiedUser { get; set; }
        public System.DateTime Created { get; set; }
        public long FK_CreatedBy { get; set; }
        public bool IsPublic { get; set; }
        public bool? IsTermsApproved { get; set; }

        public virtual City City { get; set; }

        public virtual User User { get; set; }
    }
}
