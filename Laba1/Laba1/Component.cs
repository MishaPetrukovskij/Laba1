// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Component.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Component type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Laba1
{
    using System;
    using System.Text;

    /// <summary>
    /// The component.
    /// </summary>
    public class Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        public Component()
        {
            this.Type = "Component";
            this.Name = "Noname";
        }

        public Component(string type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            string info;
            StringBuilder str = new StringBuilder();
            str.Append("Type : " + this.Type + " " + this.Name + Environment.NewLine);
            info = str.ToString();
            return info;
        }

    }
}