using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PizzaWars.API
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitClient()
        {
            ApiClient = new HttpClient();

            ApiClient.BaseAddress = new Uri("https://foodish-api.herokuapp.com/api/images/pizza");

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
