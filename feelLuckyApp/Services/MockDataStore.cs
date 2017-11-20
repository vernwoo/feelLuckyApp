using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace feelLuckyApp
{
    public class MockDataStore : IDataStore
    {
        string[] ls = { "You are really lucky!", "You are super lucky!", "You are damn lucky!" };
        public MockDataStore()
        {
        }

        public string GetLuckyString(bool forceRefresh = false)
        {
            Random r = new Random();
            int index = r.Next(ls.Length);
            return ls[index];
        }
    }
}
