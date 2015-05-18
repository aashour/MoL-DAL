using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MoL.Core.Configuration
{
    /// <summary>
    /// Represents an MoLConfig
    /// </summary>
    public partial class MoLConfig : IConfigurationSectionHandler
    {
        /// <summary>
        /// Creates a configuration section handler.
        /// </summary>
        /// <param name="parent">Parent object.</param>
        /// <param name="configContext">Configuration context object.</param>
        /// <param name="section">Section XML node.</param>
        /// <returns>The created section handler object.</returns>
        public object Create(object parent, object configContext, XmlNode section)
        {
            var config = new MoLConfig();
            var dynamicDiscoveryNode = section.SelectSingleNode(Constants.CONFIG_DYNAMIC_DISCOVERY);
            if (dynamicDiscoveryNode != null && dynamicDiscoveryNode.Attributes != null)
            {
                var attribute = dynamicDiscoveryNode.Attributes[Constants.ENABLE];
                if (attribute != null)
                    config.DynamicDiscovery = Convert.ToBoolean(attribute.Value);
            }

            var engineNode = section.SelectSingleNode(Constants.ENGINE);
            if (engineNode != null && engineNode.Attributes != null)
            {
                var attribute = engineNode.Attributes[Constants.TYPE];
                if (attribute != null)
                    config.EngineType = attribute.Value;
            }

            var startupNode = section.SelectSingleNode(Constants.STARTUP);
            if (startupNode != null && startupNode.Attributes != null)
            {
                var attribute = startupNode.Attributes[Constants.IGNORE_STARTUP_TASKS];
                if (attribute != null)
                    config.IgnoreStartupTasks = Convert.ToBoolean(attribute.Value);
            }

            var path = section.SelectSingleNode(Constants.CONFIG_PATH);
            if (path != null && path.Attributes != null)
            {
                var attribute = path.Attributes[Constants.VALUE];
                if (attribute != null)
                    config.Path = attribute.Value;
            }

            return config;
        }

        /// <summary>
        /// In addition to configured assemblies examine and load assemblies in the bin directory.
        /// </summary>
        public bool DynamicDiscovery { get; private set; }

        /// <summary>
        /// A custom <see cref="IEngine"/> to manage the application instead of the default.
        /// </summary>
        public string EngineType { get; private set; }

        /// <summary>
        /// Indicates whether we should ignore startup tasks
        /// </summary>
        public bool IgnoreStartupTasks { get; private set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public string Path { get; set; }
    }
}
