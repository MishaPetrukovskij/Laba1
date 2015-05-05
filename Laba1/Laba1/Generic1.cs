using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    /// <summary>
    /// The generic 1.
    /// </summary>
    public class Generic1 : IContravarianceGeneric<Component>
    {
        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="Component"/>.
        /// </returns>
        public Component Create()
        {
            return new Component();
        }
    }
}
