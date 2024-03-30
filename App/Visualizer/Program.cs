using AlgorithmVisualizer.Business.CodingChallenges;

using Microsoft.Extensions.DependencyInjection;

namespace Visualizer;

internal static class Program
{
    private static ServiceProvider? _serviceProvider;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        ServiceCollection services = new();
        ConfigureServices(services);
        _serviceProvider = services.BuildServiceProvider();

        MainForm mainForm = _serviceProvider.GetRequiredService<MainForm>();

        Application.Run(mainForm);
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<MainForm>();
    }
}