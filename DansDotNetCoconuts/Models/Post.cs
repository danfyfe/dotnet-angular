using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DansDotNetCoconuts.Models;

public class Post
{
  [JsonPropertyName("id")]
  public int Id { get; }
  [JsonPropertyName("title")]
  public string Title { get; set; } = default!;
  [JsonPropertyName("content")]
  public string Content { get; set; } = default!;

  public override string ToString() => JsonSerializer.Serialize<Post>(this);
}
