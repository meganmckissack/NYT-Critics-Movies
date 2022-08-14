using System.Threading.Tasks;
using RestSharp;

namespace NYTMvcApiCall.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/movies/v2");
      RestRequest request = new RestRequest($"reviews/picks.json?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}