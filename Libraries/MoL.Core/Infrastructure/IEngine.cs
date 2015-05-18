using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoL.Core.Configuration;
using MoL.Core.Infrastructure.DependencyManagement;

namespace MoL.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface can serve as a portal for the 
    /// various services composing the MoL eServices engine. Edit functionality, modules
    /// and implementations access most MoL eServices functionality through this 
    /// interface.
    /// </summary>
    public interface IEngine
    {
        ContainerManager ContainerManager { get; }

        /// <summary>
        /// Initialize components and plugins in the MoL environment.
        /// </summary>
        /// <param name="config">Config</param>
        void Initialize(MoLConfig config);

        T Resolve<T>() where T : class;

        object Resolve(Type type);

        T[] ResolveAll<T>();
    }
}
