// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CovGeneric2.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CovGeneric2 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Laba1
{
    using System;

    /// <summary>
    /// The covariance generic 2.
    /// </summary>
    public class CovGeneric2 : ICovarianceGeneric<Candy>
    {
        /// <summary>
        /// The print string.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        public void PrintString(Candy t)
        {
            Console.WriteLine(t.ToString());
        }
    }
}
