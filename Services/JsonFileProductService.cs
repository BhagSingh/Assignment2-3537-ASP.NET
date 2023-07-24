using Assignment2_3534.Models;
using System.Text.Json;

namespace Assignment2_3534.Services
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment) {
        WebHostEnvironment = webHostEnvironment;
        }


        public IWebHostEnvironment WebHostEnvironment { get; }


        //We need one more property for the jsonFileName:Two Solutions:
        //#1
       /* public string JsonFileName {
            get
            {
                return Path.Combine(webHostEnvironment.WebRootPath,"Data","Products.json");
            }
        }*/

       //#2
        public string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Products.json");

        public IEnumerable<Product> GetProducts()
        {   //(File i/o) =>open the text file
            using var jsonFileReader =File.OpenText(JsonFileName);

            // With json 

            return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
               )!;



        }
    }// Class


}
