
public class Player
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("imageLink")]
    public string ImageLink { get; set; }

    [JsonPropertyName("club")]
    public string Club { get; set; }

    [JsonPropertyName("birthday")]
    public string Birthday { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("height")]
    public double Height { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Id: {this.Id}");
        sb.AppendLine($"Name: {this.Name}");
        sb.AppendLine($"Image link: {this.ImageLink}");
        sb.AppendLine($"Club: {this.Club}");
        sb.AppendLine($"Birthday: {this.Birthday}");
        sb.AppendLine($"Weight: {this.Weight}");
        sb.AppendLine($"Height: {this.Height}");
        sb.AppendLine($"Description: {this.Description}");
        sb.AppendLine($"Position: {this.Position}");

        return sb.ToString();
    }
}