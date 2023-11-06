using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
namespace HelloCopilot{
    public class Program
    {
        static HttpClient client = new HttpClient();

        public static async Task<(string Continent, string Flag, List<string> Borders)> GetCapitalInfo(string capital)
        {
            string apiUrl = $"https://restcountries.com/v3.1/capital/{capital}";

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JArray jsonResult = JArray.Parse(responseBody);
            var countryData = jsonResult[0];
            string continent = countryData["region"].ToString();

            if (continent != "Europe")
            {
                return (Continent: "Not in Europe", Flag: null, Borders: null);
            }

            var flag = countryData["flag"].ToString();
            var borders = countryData["borders"].ToObject<List<string>>();

            return (Continent: continent, Flag: flag, Borders: borders);
        }

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter a city name (or 'exit' to quit):");
                string city = Console.ReadLine();

                if (city.ToLower() == "exit")
                {
                    break;
                }

                var countryInfo = GetCapitalInfo(city).Result;
                if (countryInfo.Continent == "Not in Europe")
                {
                    Console.WriteLine($"{city} is not a capital in Europe.");
                }
                else
                {
                    Console.WriteLine($"Continent: {countryInfo.Continent}");
                    Console.WriteLine($"Flag: {countryInfo.Flag}");
                    Console.WriteLine($"Borders: {string.Join(", ", countryInfo.Borders)}");
                }
            }
        }
    }
}