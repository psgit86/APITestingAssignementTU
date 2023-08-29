using System;

namespace APITesting
{
    internal class DisplayNameAttribute : Attribute
    {
        public DisplayNameAttribute(string description)
        {
            this.Description = description;
        }

        public string Description { get; protected set; }

    }
}