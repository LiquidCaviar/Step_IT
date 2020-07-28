using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPIPCL.WebAPIHandler
{
    public static class ApiHandler
    {
        public static string baseUrl = "https://api.themoviedb.org/3";
        public static string Key = "d19228c35fc64391f3627984299bf70b";

        public static async Task<T> GetApi<T>(string url)
        {
            var httpClient = new HttpClient();
            var apiData = await httpClient.GetStringAsync($"{baseUrl}{url}api_key={Key}");

            return JsonConvert.DeserializeObject<T>(apiData);


        }



        public static async Task<List<T>> GetApiList<T>(string url)
        {
            var httpClient = new HttpClient();
            var apiData = await httpClient.GetStringAsync($"{baseUrl}{url}api_key={Key}");

            return JsonConvert.DeserializeObject<List<T>>(apiData);

        }
    }
}
