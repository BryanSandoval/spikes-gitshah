using System.Reflection;
using FluentNHibernate;
using NHibernate.Cfg;
using Spring.Data.NHibernate;

namespace aspnetwebFormsWithMvc3App.NHibernate
{
    public class FluentNhibernateLocalSessionFactoryObject : LocalSessionFactoryObject
    {
        /// <summary>
        ///   Sets the assemblies to load that contain fluent nhibernate mappings.
        /// </summary>
        /// <value>The mapping assemblies.</value>
        public string[] FluentNhibernateMappingAssemblies { get; set; }

        /// <summary>
        /// This method will be called after the configuration is processed but before the session factory is created.  
        /// </summary>
        /// <param name="config"></param>
        protected override void PostProcessConfiguration(Configuration config)
        {
            base.PostProcessConfiguration(config);

            if (FluentNhibernateMappingAssemblies == null) return;
            foreach (string assemblyName in FluentNhibernateMappingAssemblies)
            {
                config.AddMappingsFromAssembly(Assembly.Load(assemblyName));
            }
        }
    }
}