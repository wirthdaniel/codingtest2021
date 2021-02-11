using CodingTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Data
{
    public class SqlSubscriptionData : ISubscriptionData
    {
        private readonly CodingTestDbContext _dbContext;
        public SqlSubscriptionData(CodingTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Subscription> Add(Subscription subscription)
        {
            await _dbContext.AddAsync(subscription);
            return subscription;
        }

        public Subscription GetSubscriptionByEmail(string email)
        {
            return _dbContext.Subscriptions.Where(s => s.Email == email).FirstOrDefault();
        }

        public async Task<int> Commit()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
