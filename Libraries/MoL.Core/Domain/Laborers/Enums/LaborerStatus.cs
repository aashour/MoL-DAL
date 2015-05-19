using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers.Enums
{
    public enum LaborerStatus
    {
        /// <summary> 
        /// لا يوجد
        /// </summary>
        NotFound = -1,

        /// <summary> 
        /// علي رأس العمل
        /// </summary>
        Working = 1,

        /// <summary> 
        /// علي رأس العمل و غير موجود بالإحصائيات
        /// </summary>
        WorkingNoStatistics = 2,

        /// <summary> 
        /// هارب
        /// </summary>
        Runner = 3,

        /// <summary> 
        /// موقوف عن العمل
        /// </summary>
        Suspended = 4,

        /// <summary> 
        /// خروج نهائي
        /// </summary>
        FinalExit = 5,

        /// <summary> 
        /// متوفي
        /// </summary>
        Dead = 6,

        /// <summary> 
        /// نهاية الخدمة
        /// </summary>
        ServiceEnd = 7,

        /// <summary> 
        /// نقلت خدمته
        /// </summary>
        Transfered = 8,

        /// <summary> 
        /// تغيير حالة
        /// </summary>
        ChangeWorkStatus = 9,

        /// <summary> 
        /// تحت إجراء نقل الخدمة
        /// </summary>
        SponsorTransfer = 10,

        /// <summary> 
        /// تحت إجراء عملية تغيير المهنة
        /// </summary>
        ChangeJobDescription = 11

    }
}
