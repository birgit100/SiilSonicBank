using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
using Open.Data.Bank;
using Open.Domain.Bank;
namespace Open.Tests.Domain.Bank
{
    [TestClass]
    public class RequestTransactionListTests : ListBaseTests<RequestTransactionList, RequestTransaction>
    {
        protected override RequestTransactionList getRandomObject()
        {
            createWithNullArgs = new RequestTransactionList(null, null);
            var l = GetRandom.Object<List<RequestTransactionData>>();
            return new RequestTransactionList(l, GetRandom.Object<RepositoryPage>());
        }
    }
}

