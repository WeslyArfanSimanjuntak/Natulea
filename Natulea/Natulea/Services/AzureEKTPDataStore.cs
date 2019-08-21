using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Natulea.Models;
using System.Linq;
//namespace Natulea.Services
//{
//    class AzureEKTPDataStore
//    {
//    }
//}


namespace Natulea.Services
{
    public class AzureEKTPDataStore : IAzurEKTPDataStoreIDataStore<Content>
    {
        HttpClient EKTPClient;
        Content content;

        public AzureEKTPDataStore()
        {
            string ektpREST = "http://ajk-aga.indosuryalife.co.id/hlt/EKTPApi/ceknik";
            //1212231402940001
            EKTPClient = new HttpClient();
            EKTPClient.BaseAddress = new Uri($"{ektpREST}/");
            content = new Content();
        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        public async Task<Content> GetEKTPItemAsync(string nik)
        {
            if (nik != null && IsConnected)
            {
                var json = await EKTPClient.GetStringAsync($"{nik}");
                return await Task.Run(() => JsonConvert.DeserializeObject<RootObject>(json).content.FirstOrDefault());
            }

            return null;
        }

    }
}
