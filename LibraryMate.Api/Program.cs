using ElectronNET.API;
using LibraryMate.Api;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AngularWithDotnetCoreElectronNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseElectron(args);
        }
    }
}