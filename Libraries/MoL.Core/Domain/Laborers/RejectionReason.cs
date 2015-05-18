using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoL.Core.Domain.Laborers
{
    public enum RejectionReason
    {
        /// <summary> 
        /// ييانات غير صحيحة بالسيرة الذاتية                                                                                                                                                                                                                               
        /// </summary>                                                                                                                                                                                                                          ")]
        IncorrectCVData = 1,

        /// <summary> 
        /// التقييم الشخصي                                                                                                                                                                                                                                                 
        /// </summary>                                                                                                                                                                                                                                             ")]
        PesronalAssessment = 2,

        /// <summary> 
        /// القدرات المهنية                                                                                                                                                                                                                                                
        /// </summary>                                                                                                                                                                                                                                               ")]
        JobSkills = 3,

        /// <summary> 
        /// عدم الإتفاق علي الأجر                                                                                                                                                                                                                                          
        /// </summary>                                                                                                                                                                                                                                        ")]
        SalaryConflict = 4,

        /// <summary> 
        /// أخري                                                                                                                                                                                                                                                           
        /// </summary>                                                                                                                                                                                                                                                   ")]
        Others = 5,

        /// <summary> 
        /// غير محدد
        /// </summary>
        NotYetDefined = 6

    }
}
