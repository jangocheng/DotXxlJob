using System;

namespace DotXxlJob.Core
{
    public class JobHandlerAttribute:Attribute
    {
        public JobHandlerAttribute(string name)
        {
            this.Name = name;
        }
        
        public string Name { get; }
        
        /// <summary>
        /// set Ignore 
        /// </summary>
        public bool Ignore { get; set; }
    }
}