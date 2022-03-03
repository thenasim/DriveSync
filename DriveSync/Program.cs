using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DriveSync;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        //ApplicationConfiguration.Initialize();
        //Application.Run(new StartForm());

        var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddScoped<Settings>();
                services.AddSingleton<StartForm>();
            });

        var host = builder.Build();

        using var serviceScope = host.Services.CreateScope();
        {
            var services = serviceScope.ServiceProvider;

            try
            {
                var startForm = services.GetRequiredService<StartForm>();
                Application.Run(startForm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}