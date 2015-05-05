// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Candy.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Candy type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Laba1
{
    using System;

    /// <summary>
    /// The candy.
    /// </summary>
    public class Candy : Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Candy"/> class.
        /// </summary>
        public Candy() : base("Candy", "Milka")
        {
            this.Filling = "None";
         }

        /// <summary>
        /// Initializes a new instance of the <see cref="Candy"/> class.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="filling">
        /// The filling.
        /// </param>
        public Candy(string type, string name, string filling)
            : base(type, name)
        {
            this.Filling = filling;
        }


        /// <summary>
        /// Gets the filling.
        /// </summary>
        public string Filling { get; private set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            string result = string.Empty;
            result += base.ToString();
            result += "Filling : " + this.Filling + Environment.NewLine;

            return result;
        }

    }
}
