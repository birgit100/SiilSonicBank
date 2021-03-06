﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Notification;
using Open.Domain.Notification;
namespace Open.Tests.Domain.Notification
{
    [TestClass]
    public class NotificationFactoryTests : BaseTests
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(NotificationFactory);
        }
        private void testVariables(NotificationData o, string id, string msg, DateTime vFrom,
            DateTime vTo, bool? isSeen, string sId, string rId)
        {
            Assert.AreEqual(id, o.ID);
            Assert.AreEqual(msg, o.Message);
            Assert.AreEqual(vFrom, o.ValidFrom);
            Assert.AreEqual(vTo, o.ValidTo);
            Assert.AreEqual(isSeen, o.IsSeen);
            Assert.AreEqual(sId, o.SenderId);
            Assert.AreEqual(rId, o.ReceiverId);
        }
        [TestMethod]
        public void CreateNewInsuranceNotificationTest()
        {
            var r = GetRandom.Object<NewInsuranceNotificationData>();
            r.Message = "insurance is now valid until";
            var o = NotificationFactory.CreateNewInsuranceNotification(r.ID, r.SenderId, r.ReceiverId, r.InsuranceType, r.IsSeen, r.ValidFrom, r.ValidTo);
            Assert.IsInstanceOfType(o, typeof(NewInsuranceNotification));
            testVariables(o.Data, r.ID, r.Message, r.ValidFrom, r.ValidTo, r.IsSeen, r.SenderId, r.ReceiverId);
            Assert.AreEqual(r.InsuranceType, o.Data.InsuranceType);
        }
        [TestMethod]
        public void CreateNewRequestTransactionNotificationTest()
        {
            var r = GetRandom.Object<NewRequestTransactionNotificationData>();
            r.Message = "has requested a transaction in the amount of";
            var o = NotificationFactory.CreateNewRequestTransactionNotification(r.ID, r.SenderId, r.ReceiverId, r.Amount, r.IsSeen, r.ValidFrom, r.ValidTo);
            Assert.IsInstanceOfType(o, typeof(NewRequestTransactionNotification));
            testVariables(o.Data, r.ID, r.Message, r.ValidFrom, r.ValidTo, r.IsSeen, r.SenderId, r.ReceiverId);
            Assert.AreEqual(r.Amount, o.Data.Amount);
        }
        [TestMethod]
        public void CreateNewTransactionNotificationTest()
        {
            var r = GetRandom.Object<NewTransactionNotificationData>();
            r.Message = "has sent you a new transaction in the amount of";
            var o = NotificationFactory.CreateNewTransactionNotification(r.ID, r.SenderId, r.ReceiverId, r.Amount, r.IsSeen, r.ValidFrom, r.ValidTo);
            Assert.IsInstanceOfType(o, typeof(NewTransactionNotification));
            testVariables(o.Data, r.ID, r.Message, r.ValidFrom, r.ValidTo, r.IsSeen, r.SenderId, r.ReceiverId);
            Assert.AreEqual(r.Amount, o.Data.Amount);
        }
        [TestMethod]
        public void CreateRequestStatusNotificationTest()
        {
            var r = GetRandom.Object<RequestStatusNotificationData>();
            r.Message = $"has {r.Status.ToString().ToLower()} your request for a transaction in the amount of";
            var o = NotificationFactory.CreateRequestStatusNotification(r.ID, r.SenderId, r.ReceiverId, r.Amount, r.Status, r.IsSeen, r.ValidFrom, r.ValidTo);
            Assert.IsInstanceOfType(o, typeof(RequestStatusNotification));
            testVariables(o.Data, r.ID, r.Message, r.ValidFrom, r.ValidTo, r.IsSeen, r.SenderId, r.ReceiverId);
            Assert.AreEqual(r.Amount, o.Data.Amount);
            Assert.AreEqual(r.Status, o.Data.Status);
        }
        [TestMethod]
        public void CreateWelcomeNotificationTest()
        {
            var r = GetRandom.Object<WelcomeNotificationData>();
            r.Message = "Welcome to SonicBank! Thank you for opening an account!";
            var o = NotificationFactory.CreateWelcomeNotification(r.ID, r.SenderId, r.ReceiverId, r.IsSeen, r.ValidFrom, r.ValidTo);
            Assert.IsInstanceOfType(o, typeof(WelcomeNotification));
            testVariables(o.Data, r.ID, r.Message, r.ValidFrom, r.ValidTo, r.IsSeen, r.SenderId, r.ReceiverId);
        }
        [TestMethod]
        public void CreateTest()
        {
            void test<T>(NotificationData r)
            {
                var o = NotificationFactory.Create(r);
                Assert.IsInstanceOfType(o, typeof(T));
            }
            test<NewInsuranceNotification>(GetRandom.Object<NewInsuranceNotificationData>());
            test<NewRequestTransactionNotification>(GetRandom.Object<NewRequestTransactionNotificationData>());
            test<NewTransactionNotification>(GetRandom.Object<NewTransactionNotificationData>());
            test<RequestStatusNotification>(GetRandom.Object<RequestStatusNotificationData>());
            test<WelcomeNotification>(GetRandom.Object<NotificationData>());
            test<WelcomeNotification>(GetRandom.Object<WelcomeNotificationData>());
            test<WelcomeNotification>(null);
        }
    }
}
