using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Domain.Bank;
namespace Open.Tests.Domain.Bank
{
    [TestClass]
    public class RequestTransactionTests : EntityBaseTests<RequestTransaction, RequestTransactionData>
    {
        protected override RequestTransaction getRandomObject()
        {
            createdWithNullArg = new RequestTransaction(null);
            dbRecordType = typeof(RequestTransactionData);
            return GetRandom.Object<RequestTransaction>();
        }
        [TestMethod]
        public void SenderAccountTest()
        {
            Assert.AreEqual(obj.SenderAccount.Data, obj.Data.SenderAccount);
        }
        [TestMethod]
        public void ReceiverAccountTest()
        {
            Assert.AreEqual(obj.ReceiverAccount.Data, obj.Data.ReceiverAccount);
        }
        [TestMethod]
        public void WhenCreatedWithNullArgumentsTest()
        {
            obj = new RequestTransaction(null);
            Assert.IsNull(obj.Data.SenderAccount);
            Assert.IsNotNull(obj.SenderAccount.Data);
            Assert.IsNull(obj.Data.ReceiverAccount);
            Assert.IsNotNull(obj.ReceiverAccount.Data);
        }
    }
}

