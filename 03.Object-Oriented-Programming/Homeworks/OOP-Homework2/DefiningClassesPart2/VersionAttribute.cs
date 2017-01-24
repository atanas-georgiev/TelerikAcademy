using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPart2
{
    /// <summary>
    /// Problem 11. Version attribute
    /// Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
    /// Apply the version attribute to a sample class and display its version at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public string Version { get; set; }
        public VersionAttribute(string version)
        {
            this.Version = version;
        }        
    }

    [Version("2.11")]
    class TestAttribute
    {
        
    }
}
