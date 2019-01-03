using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
namespace Open.Tests.Core
{
    [TestClass]
    public class StatusTests : ClassTests<Status>
    {
        [TestMethod]
        public void CountTest()
        {
            Assert.AreEqual(2, GetEnum.Count<Status>());
        }

        [TestMethod]
        public void ActiveTest() =>
            Assert.AreEqual(0, (int)Status.Active);

        [TestMethod]
        public void InactiveTest() =>
            Assert.AreEqual(1, (int)Status.Inactive);
    }
}


