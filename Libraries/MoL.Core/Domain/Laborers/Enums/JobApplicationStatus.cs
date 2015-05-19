using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers.Enums
{
    public enum JobApplicationStatus
    {
        /// <summary> 
        /// تحت الفحص
        /// </summary>
        Opened = 1,

        /// <summary> 
        /// موافقة 
        /// </summary>
        Approved = 2,

        /// <summary> 
        /// مرفوض
        /// </summary>
        Rejected = 3,

        /// <summary> 
        /// مغلقة
        /// </summary>
        Closed = 4,

        /// <summary> 
        /// غير مهتم
        /// </summary>
        Declined = 5,

        /// <summary> 
        /// تم التوظيف
        /// </summary>
        Employed = 6,

        /// <summary> 
        /// تم التوظيف بوظيفة اخرى
        /// </summary>
        EmployedInAnotherJob = 7

    }
}
