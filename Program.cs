namespace ElsaQuickstarts.Server.DashboardAndServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                      .ConfigureWebHostDefaults(webBuilder =>
                      {
                          webBuilder.UseStartup<Startup>();
                      })
                      .ConfigureAppConfiguration(configuration =>
                      {
                          configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                      });
        }

    }
}
