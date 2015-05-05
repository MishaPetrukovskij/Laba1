
namespace Laba1
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The Generic interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1622:GenericTypeParameterDocumentationMustHaveText", Justification = "Reviewed. Suppression is OK here.")]
    public interface IContravarianceGeneric<out T> 
        where T : Component
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Create();
    }
}
