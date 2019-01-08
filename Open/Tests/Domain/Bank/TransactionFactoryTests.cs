using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
using Open.Data.Bank;
using Open.Domain.Bank;
namespace Open.Tests.Domain.Bank
{
    [TestClass]
    public class TransactionFactoryTests : BaseTests
    {
        private string id;
        private decimal amount;
        private string explanation;
        private string senderAccountId;
        private string receiverAccountId;
        private TransactionStatus status;
        private DateTime validFrom;
        private DateTime validTo;
        private Transaction tra;
        private RequestTransaction req;

        private void initializeTestData()
        {
            var min = DateTime.Now.AddYears(-50);
            var max = DateTime.Now.AddYears(50);
            id = GetRandom.String();
            amount = GetRandom.Decimal();
            explanation = GetRandom.String();
            senderAccountId = GetRandom.String();
            receiverAccountId = GetRandom.String();
            status = GetRandom.Enum<TransactionStatus>();
            validFrom = GetRandom.DateTime(min, max);
            validTo = GetRandom.DateTime(validFrom, max);
        }
        private void validateTransactionResults(string i = Constants.Unspecified,
            decimal? a = 0, string e = Constants.Unspecified, string s = Constants.Unspecified,
            string r = Constants.Unspecified, DateTime? f = null, DateTime? t = null)
        {
            Assert.AreEqual(i, tra.Data.ID);
            Assert.AreEqual(a, tra.Data.Amount);
            Assert.AreEqual(e, tra.Data.Explanation);
            Assert.AreEqual(s, tra.Data.SenderAccountId);
            Assert.AreEqual(r, tra.Data.ReceiverAccountId);
            Assert.AreEqual(f ?? DateTime.MinValue, tra.Data.ValidFrom);
            Assert.AreEqual(t ?? DateTime.MaxValue, tra.Data.ValidTo);
        }
        private void validateRequestResults(string i = Constants.Unspecified,
            decimal? a = 0, string e = Constants.Unspecified, string s = Constants.Unspecified,
            string r = Constants.Unspecified, DateTime? f = null, DateTime? t = null, TransactionStatus stat = TransactionStatus.Pending)
        {
            Assert.AreEqual(i, req.Data.ID);
            Assert.AreEqual(a, req.Data.Amount);
            Assert.AreEqual(e, req.Data.Explanation);
            Assert.AreEqual(s, req.Data.SenderAccountId);
            Assert.AreEqual(r, req.Data.ReceiverAccountId);
            Assert.AreEqual(f ?? DateTime.MinValue, req.Data.ValidFrom);
            Assert.AreEqual(t ?? DateTime.MaxValue, req.Data.ValidTo);
            Assert.AreEqual(stat, req.Data.Status);
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(TransactionFactory);
            initializeTestData();
        }
        [TestMethod]
        public void CreateTransactionTest()
        {
            tra = TransactionFactory.CreateTransaction(id, amount, explanation, senderAccountId, receiverAccountId, validFrom, validTo);
            validateTransactionResults(id, amount, explanation, senderAccountId, receiverAccountId, validFrom, validTo);
        }
        [TestMethod]
        public void CreateRequestTest()
        {
            req = TransactionFactory.CreateRequest(id, amount, explanation, senderAccountId, receiverAccountId, status, validFrom, validTo);
            validateRequestResults(id, amount, explanation, senderAccountId, receiverAccountId, validFrom, validTo, status);
        }
        [TestMethod]
        public void CreateTest()
        {
            void test<T>(BaseTransactionData r)
            {
                var o = TransactionFactory.Create(r);
                Assert.IsInstanceOfType(o, typeof(T));
            }
            test<Transaction>(GetRandom.Object<TransactionData>());
            test<RequestTransaction>(GetRandom.Object<RequestTransactionData>());
            test<Transaction>(null);
        }
    }
}


