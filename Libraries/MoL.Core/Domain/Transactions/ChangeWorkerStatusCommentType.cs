using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Transactions
{
    public enum ChangeWorkerStatusCommentType
    {
        /// <summary> 
        /// موافقة
        /// </summary>
        RequestApproved = 1,

        /// <summary> 
        /// رفض
        /// </summary>
        RequestRejected = 2,

        /// <summary> 
        /// استدعاء مقدم الطلب
        /// </summary>
        ApplicantInvitation = 3

    }
}
