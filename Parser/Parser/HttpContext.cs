using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Parser
{
    public class HttpContext
    {
        private String Uri { get; set; }

        // Инициалиазация экземляра класса
        public HttpContext(string uri)
        {
            Uri = uri;
        }

       /// <summary>
       /// Метод на поулчение пользователя по id
       /// </summary>
       /// <returns></returns>
       public String GetUserById(string Id)
       {
            var client = new RestClient(Uri);
            var request = new RestRequest($"api/users/{Id}", DataFormat.Json);
            var response = client.Get(request);

            if(response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return response.Content;
       }

     
       
    }
}
