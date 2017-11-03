using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AzureMongoDbOnion
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // var subjectProvider = new SubjectProvider();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
