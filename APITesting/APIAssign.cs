using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APITesting
{
    public class APIAssign
    {

        public ListOfUsers GetUsers()
        {
            var restClient = new RestClient("https://swapi.dev/api/");
            var restRequest = new RestRequest("/people/",Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<ListOfUsers>(content);
            return users;

        }

        public ListOfUsers GetPostcodes()
        {
            var restClient = new RestClient("https://api.postcodes.io/");
            var restRequest = new RestRequest("/postcodes/", Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddJsonBody({
                     postcodes: ["OX49 5NU", "M32 0JG", "NE30 1DP"]}
             );
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<ListOfUsers>(content);
            return users;

        }
    }
}
