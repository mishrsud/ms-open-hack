using System;
using System.Threading.Tasks;
using MCServerStatus;
using MCServerStatus.Models;

namespace MinecraftMonotor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    var monitorMessage = await StartMonitoring();
                    Console.WriteLine(monitorMessage);
                    await Task.Delay(TimeSpan.FromSeconds(5));
                }
            }).Wait();
        }

        private static async Task<string> StartMonitoring()
        {
            try
            {
                MinecraftPinger mcServerStatus = new MinecraftPinger("13.75.221.179", 25565);
                Status minecraftStatus = await mcServerStatus.PingAsync();


                var monitorMessage = $"mcnumplayers={minecraftStatus.Players.Online}, " +
                                     $"mccapacity={minecraftStatus.Players.Max}, " +
                                     $"mcpopulation={minecraftStatus.Players?.Sample?.Count}";

                return monitorMessage;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception: {exception.Message}, Deails:{exception.StackTrace}");
                return string.Empty;
            }
        }
    }
}
