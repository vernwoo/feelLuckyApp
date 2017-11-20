using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Plugin.Connectivity;

namespace feelLuckyApp
{
    public class CloudDataStore : IDataStore
    {
        HttpClient client;

        public CloudDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.BackendUrl}/");
        }

        public string GetLuckyString(bool forceRefresh = false)
        {
            string luckystring = "You are lucky today!";
            if (forceRefresh && CrossConnectivity.Current.IsConnected)
            {
                luckystring = client.GetStringAsync(client.BaseAddress).Result;
            }

            return luckystring;
        }

    }
}
