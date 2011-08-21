using System;
using Spring.Context.Support;

namespace aspnetwebFormsWithMvc3App.Context
{
    public class MvcWebContextHandler : MvcContextHandler
    {
        protected override Type DefaultApplicationContextType
        {
            get { return typeof(MvcWebApplicationContext); }
        }                  
    }
}