using System.Text.Json.Serialization;

namespace Assignment2_3534.Models
{
    public class Product
    {
        /*The json properties for each element:
         ""id"
         maker
        url
        title

         
         */
        public string? Id { get; set; }
        public string? Maker { get; set; }
        [
            JsonPropertyName("img")]
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }





    }
}
