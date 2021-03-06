﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoL.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface provide information about types 
    /// to various services in the MoL eServices engine.
    /// </summary>
    public interface ITypeFinder
    {
        /// <summary>
        /// Gets the assemblies.
        /// </summary>
        /// <returns></returns>
        IList<Assembly> GetAssemblies();

        /// <summary>
        /// Finds the type of the classes of.
        /// </summary>
        /// <param name="assignTypeFrom">The assign type from.</param>
        /// <param name="onlyConcreteClasses">if set to <c>true</c> [only concrete classes].</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreteClasses = true);

        /// <summary>
        /// Finds the type of the classes of.
        /// </summary>
        /// <param name="assignTypeFrom">The assign type from.</param>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="onlyConcreteClasses">if set to <c>true</c> [only concrete classes].</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true);

        /// <summary>
        /// Finds the type of the classes of.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="onlyConcreteClasses">if set to <c>true</c> [only concrete classes].</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType<T>(bool onlyConcreteClasses = true);

        /// <summary>
        /// Finds the type of the classes of.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="onlyConcreteClasses">if set to <c>true</c> [only concrete classes].</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType<T>(IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true);

        /// <summary>
        /// Finds the type of the classes of.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TAssemblyAttribute">The type of the assembly attribute.</typeparam>
        /// <param name="onlyConcreteClasses">if set to <c>true</c> [only concrete classes].</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType<T, TAssemblyAttribute>(bool onlyConcreteClasses = true) where TAssemblyAttribute : Attribute;

        /// <summary>
        /// Finds the assemblies with attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<Assembly> FindAssembliesWithAttribute<T>();

        /// <summary>
        /// Finds the assemblies with attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblies">The assemblies.</param>
        /// <returns></returns>
        IEnumerable<Assembly> FindAssembliesWithAttribute<T>(IEnumerable<Assembly> assemblies);

        /// <summary>
        /// Finds the assemblies with attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <returns></returns>
        IEnumerable<Assembly> FindAssembliesWithAttribute<T>(DirectoryInfo assemblyPath);


    }
}
