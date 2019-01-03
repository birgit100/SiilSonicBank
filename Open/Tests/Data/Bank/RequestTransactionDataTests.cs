using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Data.Common;
namespace Open.Tests.Data.Bank
{
    [TestClass]
    public class RequestTransactionDataTests : ObjectTests<RequestTransactionData>
    {
        class testClass : RequestTransactionData { }
        protected override RequestTransactionData getRandomObject()
        {
            return GetRandom.Object<testClass>();
        }
        [TestMethod]
        public void IsInstanceOfBaseTransactionData()
        {
            Assert.AreEqual(typeof(BaseTransactionData), typeof(RequestTransactionData).BaseType);
        }
        [TestMethod]
        public void StatusTest()
        {
            canReadWrite(() => obj.Status, x => obj.Status = x);
        }
    }
}