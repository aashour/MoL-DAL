using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Domain.Representitives.Enums
{
    public enum AgentType : int
    {
        /// <summary> 
        /// وكيل الرقم الموحد
        /// </summary>
        UNAgent = 1,

        /// <summary> 
        /// وكيل المنشأة
        /// </summary>
        EstablishmentAgent = 2
    }
}
