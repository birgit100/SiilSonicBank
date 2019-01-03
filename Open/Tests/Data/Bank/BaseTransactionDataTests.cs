using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Data.Common;
namespace Open.Tests.Data.Bank
{
    [TestClass]
    public class BaseTransactionDataTests : ObjectTests<BaseTransactionData>
    {
        class testClass : BaseTransactionData { }
        protected override BaseTransactionData getRandomObject()
        {
            return GetRandom.Object<testClass>();
        }
        [TestMethod]
        public void IsInstanceOfIdentifiedData()
        {
            Assert.AreEqual(typeof(IdentifiedData), typeof(BaseTransactionData).BaseType);
        }
        [TestMethod]
        public void AmountTest()
        {
            canReadWrite(() => obj.Amount, x => obj.Amount = x);
        }
        [TestMethod]
        public void ExplanationTest()
        {
            canReadWrite(() => obj.Explanation, x => obj.Explanation = x);
        }
        [TestMethod]
        public void SenderAccountIdTest()
        {
            canReadWrite(() => obj.SenderAccountId, x => obj.SenderAccountId = x);
        }
        [TestMethod]
        public void ReceiverAccountIdTest()
        {
            canReadWrite(() => obj.ReceiverAccountId, x => obj.ReceiverAccountId = x);
        }
        [TestMethod]
        public void SenderAccountTest()
        {
            canReadWrite(() => obj.SenderAccount, x => obj.SenderAccount = x);
        }
        [TestMethod]
        public void ReceiverAccountTest()
        {
            canReadWrite(() => obj.ReceiverAccount, x => obj.ReceiverAccount = x);
        }
    }
}