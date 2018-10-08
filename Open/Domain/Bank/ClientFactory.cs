﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Open.Data.Bank;
namespace Open.Domain.Bank
{
    public static class ClientFactory
    {
        public static Client CreateClient(string id, string firstName, string lastName, string passwordHash, DateTime? validFrom = null, DateTime? validTo = null)
        {
            var r = new ClientData
            {
                ID = id,
                FirstName = firstName,
                LastName = lastName,
                //PasswordHash = passwordHash,
                ValidFrom = validFrom?? DateTime.MinValue,
                ValidTo = validTo?? DateTime.MaxValue
            };
            return new Client(r);
        }
    }
}
