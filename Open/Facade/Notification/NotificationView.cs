﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Open.Facade.Common;
namespace Open.Facade.Notification
{

    public abstract class NotificationView : EntityView
    {
        private string message;
        private string senderAccountId;
        private string receiverAccountId;

        [DisplayName("Notification type")]
        public string AddressType
        {
            get
            {
                var name = GetType().Name;
                var suffix = typeof(NotificationView).Name;
                var idx = name.IndexOf(suffix, StringComparison.Ordinal);
                if (idx >= 0) name = name.Substring(0, idx);
                return name;
            }
        }
        [Required]
        public virtual string Message
        {
            get => getString(ref message);
            set => message = value;
        }
        [DisplayName("Sent From")]
        public string SenderAccountId {
            get => getString(ref senderAccountId);
            set => senderAccountId = value;
        }
        [DisplayName("Sent To")]
        public string ReceiverAccountId
        {
            get => getString(ref receiverAccountId);
            set => receiverAccountId = value;
        }
    }

}


