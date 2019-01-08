using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Domain.Bank;
using Open.Facade.Bank;
namespace Open.Tests.Facade.Bank
{

    [TestClass]
    public class RequestTransactionViewsListTests : ObjectTests<RequestTransactionViewsList>
    {
        protected override RequestTransactionViewsList getRandomObject()
        {
            var l = new RequestTransactionList(null, null);
            SetRandom.Values(l);
            return new RequestTransactionViewsList(l);
        }

        [TestMethod]
        public void CanCreateWithNullArgumentTest()
        {
            Assert.IsNotNull(new RequestTransactionViewsList(null));
        }

    }
}