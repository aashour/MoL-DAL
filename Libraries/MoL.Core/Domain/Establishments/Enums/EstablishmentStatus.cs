using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Establishments.Enums
{
    public enum EstablishmentStatus : int
    {
        /// <summary> 
        /// قائمة
        /// </summary>
        Existent = 1,

        /// <summary> 
        /// غير قائمة
        /// </summary>
        NonExistent = 2,

        /// <summary> 
        /// منقولة
        /// </summary>
        Transfered = 3,

        /// <summary> 
        /// مباعة
        /// </summary>
        Sold = 4,

        /// <summary> 
        /// فى إنتظار رد الداخلية
        /// </summary>
        MOIPending = 5,

        /// <summary> 
        /// تحت الإجراء
        /// </summary>
        UnderProcedure = 6,

        /// <summary> 
        /// ملغاه
        /// </summary>
        Canceled = 7,

        /// <summary> 
        /// جديدة
        /// </summary>
        NewRequest = 100,

        /// <summary> 
        /// تحت الدراسة
        /// </summary>
        UnderProgress = 101,

        /// <summary> 
        /// مرفوض
        /// </summary>
        Rejected = 102,

        /// <summary> 
        /// مقبول
        /// </summary>
        Approved = 103,

        /// <summary> 
        /// ملغي
        /// </summary>
        RolledBack = 104
    }
}
