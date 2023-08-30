using System.Text.Json;
using Types;

// #nullable enable

namespace Main
{
    class App
    {
        static async Task Main()
        {
            var name = new Dictionary<string, object>();

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
            HttpResponseMessage response = await client.GetAsync("https://hip-expensive-fuschia.glitch.me/api/metadata");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Root? json = JsonSerializer.Deserialize<Root>(responseBody);

                if (json != null)
                {
                    Console.WriteLine(json!.username);
                    Console.WriteLine(json?.statics?.tickets?.total);

                }
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
