using System.Xml;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.IO;
using Spring.Objects.Factory.Support;
using Spring.Objects.Factory.Xml;

namespace aspnetwebFormsWithMvc3App.Context
{
    public class MvcWebApplicationContext : MvcApplicationContext
    {
        public MvcWebApplicationContext(string name, bool caseSensitive, params string[] configurationLocations)
            : this(new MvcApplicationContextArgs(name, null, configurationLocations, null, caseSensitive))
        { }

        public MvcWebApplicationContext(string name, bool caseSensitive, IApplicationContext parentContext, params string[] configurationLocations)
            : this(new MvcApplicationContextArgs(name, parentContext, configurationLocations, null, caseSensitive))
        { }

        public MvcWebApplicationContext(MvcApplicationContextArgs args)
            : base(args)
        { }

        public MvcWebApplicationContext(string name, bool caseSensitive, string[] configurationLocations, IResource[] configurationResources)
            : this(new MvcApplicationContextArgs(name, null, configurationLocations, configurationResources, caseSensitive))
        { }

        public MvcWebApplicationContext(params string[] configurationLocations)
            : this(new MvcApplicationContextArgs(string.Empty, null, configurationLocations, null, false))
        { }

        /// <summary>
        /// Overriding the method CreateXmlObjectDefinitionReader to return the instance of WebObjectDefinitionReader.
        /// </summary>
        /// <param name="objectFactory"></param>
        /// <returns></returns>
        protected override XmlObjectDefinitionReader CreateXmlObjectDefinitionReader(DefaultListableObjectFactory objectFactory)
        {
            return new WebObjectDefinitionReader(GetContextPathWithTrailingSlash(), objectFactory, new XmlUrlResolver());
        }

        /// <summary>
        /// Returning the instance of WebObjectFactory so that it recognizes the session scope attribute.
        /// </summary>
        /// <returns></returns>
        protected override DefaultListableObjectFactory CreateObjectFactory()
        {
            return new WebObjectFactory(GetContextPathWithTrailingSlash(), IsCaseSensitive);
        }

        private string GetContextPathWithTrailingSlash()
        {
            string contextPath = Name;
            if (contextPath == DefaultRootContextName)
            {
                contextPath = "/";
            }
            else
            {
                contextPath = contextPath + "/";
            }
            return contextPath;
        }
    }
}