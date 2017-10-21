using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetCoFoBA
{
    public class NetCoFoBAClient
    {
        public string ApiUrl {get; set;} = "http://cfba.org.ar/feed/";
        
        public string ApiKey {get; set;} = "MY-API-KEY";
        
        public async Task<string> GetData()
        {
            var result = string.Empty;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                
                var response = await client.GetAsync(ApiUrl);
                
                if(response.IsSuccessStatusCode)
                    result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}
