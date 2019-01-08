using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Domain.Bank;
namespace Open.Tests.Domain.Bank
{
    [TestClass]
    public class BaseTransactionTests : EntityBaseTests<BaseTransaction<TransactionData>,
        TransactionData>
    {
        class testClass : BaseTransaction<TransactionData>
        {
            public testClass(TransactionData r) : base(r) { }
        }
        protected override BaseTransaction<TransactionData> getRandomObject()
        {
            createdWithNullArg = new testClass(null);
            dbRecordType = typeof(BaseTransactionData);
            return GetRandom.Object<testClass>();
        }

        [TestMethod]
        public void IsITransactionObjectTest()
        {
            Assert.IsInstanceOfType(obj, typeof(ITransaction));
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
    }
}


