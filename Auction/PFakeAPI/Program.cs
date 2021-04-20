using Auction.PFakeAPI.Infra;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Auction.PFakeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO Fake'imine
            //InitializeData.CreateFakeData();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
