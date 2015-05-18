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
    /// Configures the inversion of control container with services used by mol.
    /// </summary>
    public class ContainerConfigurer
    {
        /// <summary>
        /// Configures the specified engine.
        /// </summary>
        /// <param name="engine">The engine.</param>
        /// <param name="containerManager">The container manager.</param>
        /// <param name="configuration">The configuration.</param>
        public virtual void Configure(IEngine engine, ContainerManager containerManager, MoLConfig configuration)
        {
            //other dependencies
            containerManager.AddComponentInstance<MoLConfig>(configuration, "mol.configuration");
            containerManager.AddComponentInstance<IEngine>(engine, "mol.engine");
            containerManager.AddComponentInstance<ContainerConfigurer>(this, "mol.containerConfigurer");

            //type finder
            containerManager.AddComponent<ITypeFinder, WebAppTypeFinder>("mol.typeFinder");

            //register dependencies provided by other assemblies
            var typeFinder = containerManager.Resolve<ITypeFinder>();
            containerManager.UpdateContainer(x =>
            {
                var drTypes = typeFinder.FindClassesOfType<IDependencyRegistrar>();
                var drInstances = new List<IDependencyRegistrar>();
                foreach (var drType in drTypes)
                    drInstances.Add((IDependencyRegistrar)Activator.CreateInstance(drType));
                //sort
                drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();
                foreach (var dependencyRegistrar in drInstances)
                    dependencyRegistrar.Register(x, typeFinder);
            });
        }
    }
}
