using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers.Enums
{
    public enum JobVacancyStatus
    {
        /// <summary> 
        /// فعاله
        /// </summary>
        Opened = 1,

        /// <summary> 
        /// مكتملة
        /// </summary>
        Completed = 2,

        /// <summary> 
        /// منتهية
        /// </summary>
        Expired = 3,

        /// <summary> 
        /// مغلقة
        /// </summary>
        Closed = 4

    }
}
