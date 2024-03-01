using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DansDotNetCoconuts.Models;
using Microsoft.AspNetCore.Hosting;

namespace DansDotNetCoconuts.WebSite.Services
{
  public class JsonFilePostService
  {
    public JsonFilePostService(IWebHostEnvironment webHostEnvironment)
    {
      // constructor accepts webHostEnvironment
      WebHostEnvironment = webHostEnvironment;
    }

    // allows us to set the WebHostEnvironment as the passed in webHostEnvironment
    public IWebHostEnvironment WebHostEnvironment { get; }

    private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "dummyPosts.json");

    public IEnumerable<Post> GetPosts()
    {
      using var jsonFileReader = File.OpenText(JsonFileName);
      return JsonSerializer.Deserialize<Post[]>(jsonFileReader.ReadToEnd(),
          new JsonSerializerOptions
          {
            PropertyNameCaseInsensitive = true
          });
    }

  }
}