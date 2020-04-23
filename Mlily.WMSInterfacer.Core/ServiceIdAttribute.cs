using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceIdAttribute:Attribute
    {
        public string Name { get; set; }

        public ServiceIdAttribute(string name)
        {
            this.Name = name;
        }
    }
}
