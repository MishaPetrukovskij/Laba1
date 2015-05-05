using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    using Laba1;
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IContravarianceGeneric<Component> desk1 = new Generic1();
            IContravarianceGeneric<Candy> desk2 = new Generic2();

            desk1 = (IContravarianceGeneric<Component>) desk2;
          //  desk2 = desk1;
        }
    }
}
