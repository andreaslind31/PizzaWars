using PizzaWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace PizzaWars.API
{
    public class PizzaProcessor
    {
        public static async Task<PizzaModel> LoadPizza()
        {

            string url = ApiHelper.ApiClient.BaseAddress.ToString();


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    PizzaModel data = await response.Content.ReadAsAsync<PizzaModel>();

                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }

        }
        public static async Task<PizzaListModel> LoadPizzaList()
        {
            string search = "search";
            string url = ApiHelper.ApiClient.BaseAddress.ToString() + search;


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    PizzaListModel data = await response.Content.ReadAsAsync<PizzaListModel>();

                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }

        }
    }
}
