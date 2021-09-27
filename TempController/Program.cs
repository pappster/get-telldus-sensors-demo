using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wolfberry.TelldusLive;

namespace TempController
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var consumerKey = "";
            var consumerKeySecret = "";
            var accessToken = "";
            var accessTokenSecret = "";

            var telldusClient = new TelldusLiveClient(
                    consumerKey, consumerKeySecret, accessToken, accessTokenSecret);

            var sensors = await telldusClient.Sensors.GetSensorsAsync(true, true);

            var json = JsonConvert.SerializeObject(sensors);

            Console.WriteLine($"JSON data: {json}");
        }
    }
}
