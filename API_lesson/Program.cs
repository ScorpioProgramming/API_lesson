using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;


namespace API_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://");
            var request = new RestRequest("/", Method.GET);
            IRestResponse response = client.Execute(request);
            String content = response.Content;
            Menu menu = JsonConvert.DeserializeObject<Menu>(content);
            
        }
    }
}
