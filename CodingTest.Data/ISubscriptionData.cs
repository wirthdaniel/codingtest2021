using CodingTest.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Data
{
    public interface ISubscriptionData
    {
        Subscription GetSubscriptionByEmail(string email);

        Task<Subscription> Add(Subscription subscription);

        Task<int> Commit();
    }
}
