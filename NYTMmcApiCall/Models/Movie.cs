
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NYTMvcApiCall.Models
{
  public class Movie
  {
    public string Display_Title { get; set; }
    public string Mpaa_Rating { get; set; }
    public string Headline { get; set; }
    public string Summary_Short { get; set; }

    public static List<Movie> GetMovies(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse["results"].ToString());

      return movieList;
    }
  }
}