
namespace Laba1
{
    /// <summary>
    /// The generic 2.
    /// </summary>
    public class Generic2 : IContravarianceGeneric<Candy>
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="Candy"/>.
        /// </returns>
        public Candy Create()
        {
            return new Candy();
        }
    }
}
