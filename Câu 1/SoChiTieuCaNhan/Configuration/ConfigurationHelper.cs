using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace SoChiTieuCaNhan.Configuration;

public static class ConfigurationHelper
{
    private static AppSettings? _appSettings;
    private static IConfigurationRoot? _configuration;

    public static AppSettings Current
    {
        get
        {
            if (_appSettings == null)
            {
                LoadConfiguration();
            }
            return _appSettings!;
        }
    }

    public static IConfigurationRoot Configuration
    {
        get
        {
            if (_configuration == null)
            {
                LoadConfiguration();
            }
            return _configuration!;
        }
    }

    public static void LoadConfiguration()
    {
        var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";

        var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true);

        _configuration = builder.Build();

        var settings = new AppSettings();
        _configuration.Bind(settings);
        _appSettings = settings;
    }
}
