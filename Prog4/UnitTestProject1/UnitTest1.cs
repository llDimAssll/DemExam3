using Microsoft.VisualStudio.TestTools.UnitTesting;
using Authorization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(UserAuthorization.Verification("admin", "admin"), 1);
            Assert.AreEqual(UserAuthorization.Verification("adin", "amin"), 0);
            Assert.AreEqual(UserAuthorization.Verification("admin", "admn"), 2);
        }
    }
}
