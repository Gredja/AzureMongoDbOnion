﻿
using System;

namespace AzureMongoDbOnion.Infrastructure.Dto
{
    public class Credit
    {
        public string Id { get; set; }

        public string DebtorId { get; set; }

        public string Currency { get; set; }

        public int Amount { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool Active { get; set; } = true;

        public string Comment { get; set; }
    }
}
