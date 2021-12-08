using XF.NET;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XF.NET.Models;

namespace XF.NET.Test;

internal static class Test
{
    public static async Task Main(string[] _)
    {
        string json = File.ReadAllText("config.json");
        var conf = JObject.Parse(json);
        string apiUrl = conf["url"]?.ToString() ?? throw new JsonSerializationException();
        string apiKey = conf["key"]?.ToString() ?? throw new JsonSerializationException();

        SuperUserXFClient su = XFClient.CreateSuperUserClient(new Uri(apiUrl), apiKey);
        XFUser user = await su.Users.SearchByIdAsync(null, 680);
        Print(user);

        Console.ReadKey();
    }

    private static void Print<T>(T obj)
    {
        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        Console.WriteLine(json);
    }
}
