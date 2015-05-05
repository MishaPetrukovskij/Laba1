// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICovarianceGeneric.cs" company="">
//   
// </copyright>
// <summary>
//   The CovarianceGeneric interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Laba1
{
    /// <summary>
    /// The CovarianceGeneric interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ICovarianceGeneric<in T> 
        where T : Component
    {
        /// <summary>
        /// The print string.
        /// </summary>
        void PrintString(T t);
    }
    
}
