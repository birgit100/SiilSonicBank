using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Facade.Common;
using Open.Facade.Bank;
namespace Open.Tests.Facade.Bank
{

    [TestClass]
    public class RequestTransactionViewTests : ViewTests<RequestTransactionView, TransactionView>
    {

        protected override RequestTransactionView getRandomObject()
        {
            return GetRandom.Object<RequestTransactionView>();
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
        public void StatusTest()
        {
            canReadWrite(() => obj.Status, x => obj.Status = x);
        }
    }
}

