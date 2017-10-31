﻿using AzureMongoDbOnion.Infrastructure.Data.Models;
using AzureMongoDbOnion.Infrastructure.Dto;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AzureMongoDbOnion.Infrastructure.Data.Helpers
{
    public class MongoDbContex
    {
        private readonly IMongoDatabase _database;

        public MongoDbContex(IOptions<Settings> settings)
        {
            _database = new MongoClient(settings.Value.ConnectionString).GetDatabase(settings.Value.Database);
        }

         public IMongoCollection<Debtor> Debtors => _database.GetCollection<Debtor>("Debtor");

          public IMongoCollection<Credit> Credits => _database.GetCollection<Credit>("Credit");
    }
}
