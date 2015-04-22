using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsInUnitTest()
        {
            Assert.IsTrue(UnitTestDetector.IsInUnitTest,
                "Should detect that we are running inside a unit test."); 
        }

        [TestMethod]
        public void ShouldReturn()
        {
            Program.Main(new string[]{});
        }
    }
}
