using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    using Laba1;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IContravarianceGeneric<Component> desk1 = new Generic1();
            IContravarianceGeneric<Candy> desk2 = new Generic2();

        
            desk2 = (IContravarianceGeneric<Candy>)desk1;
            desk2.ToString();

        }
    }
}
