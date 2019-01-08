using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
using Open.Data.Bank;
using Open.Domain.Bank;
using Open.Infra.Bank;
namespace Open.Tests.Infra.Bank
{
    [TestClass]
    public class RequestTransactionRepositoryTests : PaginatedRepositoryTests<RequestTransaction, RequestTransactionData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(RequestTransactionRepository);
        }
        protected override string getRandomMemberStringValue(RequestTransactionData d)
        {
            var i = GetRandom.UInt32() % 6;
            if (i == 0) return d.Amount.ToString();
            if (i == 1) return d.SenderAccountId;
            if (i == 2) return d.ReceiverAccountId;
            if (i == 3) return d.ID;
            if (i == 4) return d.Explanation;
            if (i == 5) return d.Status.ToString();
            return base.getRandomMemberStringValue(d);
        }
        protected override Func<RequestTransactionData, object> getRandomSortFunction()
        {
            var i = GetRandom.UInt32() % 7;
            if (i == 0) return x => x.Amount.ToString();
            if (i == 1) return x => x.SenderAccountId;
            if (i == 2) return x => x.ReceiverAccountId;
            if (i == 3) return x => x.ID;
            if (i == 4) return x => x.Explanation;
            if (i == 5) return x => x.ValidTo;
            if (i == 6) return x => x.Status;
            return x => x.ValidFrom;
        }
        protected override DbSet<RequestTransactionData> getDbSet() => db.RequestTransactions;
        protected override ICrudRepository<RequestTransaction> getRepository() => new RequestTransactionRepository(db);
        protected override RequestTransaction createObject(RequestTransactionData r) => new RequestTransaction(r);
        protected override RequestTransactionData getData(RequestTransaction o) => o.Data;
        protected override string getID(RequestTransactionData r) => r.ID;
        protected override void setRandomValues(RequestTransaction o)
        {
            o.Data.Amount = GetRandom.Decimal();
            o.Data.Explanation = GetRandom.String();
            o.Data.Status = GetRandom.Enum<TransactionStatus>();
            base.setRandomValues(o);
        }
        protected override void validateDbRecords(RequestTransactionData e, RequestTransactionData a)
        {
            Assert.AreEqual(e.Amount, a.Amount);
            Assert.AreEqual(e.Explanation, a.Explanation);
            Assert.AreEqual(e.Status, a.Status);
            base.validateDbRecords(e, a);
        }
        [TestMethod]
        public void CanCreate()
        {
            Assert.IsNotNull(new RequestTransactionRepository(null));
        }
        [TestMethod]
        public void LoadReceivedRequestsForAccountTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void LoadSentRequestsForAccountTest()
        {
            Assert.Inconclusive();
        }
    }
}


