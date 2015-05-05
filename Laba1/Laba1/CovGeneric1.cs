// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CovGeneric1.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CovGeneric1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Laba1
{
    using System;

    /// <summary>
    /// The covariance generic 1.
    /// </summary>
    public class CovGeneric1 : ICovarianceGeneric<Component>
    {
        /// <summary>
        /// The print string.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        public void PrintString(Component t)
        {
            Console.WriteLine(t.ToString());
        }
    }
}
