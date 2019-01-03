using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Data.Common;
namespace Open.Tests.Data.Bank
{
    [TestClass]
    public class TransactionDataTests : ObjectTests<TransactionData>
    {
        class testClass : TransactionData { }
        protected override TransactionData getRandomObject()
        {
            return GetRandom.Object<testClass>();
        }
        [TestMethod]
        public void IsInstanceOfBaseTransactionData()
        {
            Assert.AreEqual(typeof(BaseTransactionData), typeof(TransactionData).BaseType);
        }
    }
}