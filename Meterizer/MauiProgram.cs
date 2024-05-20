using CommunityToolkit.Maui;
using Meterizer.ViewModels;
using Meterizer.Views;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Meterizer;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        return MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .AddViews()
            .AddViewModels()
            .AddServices()
            .UseMauiCommunityToolkit()
            .ConfigureApplication()
            .Build();
    }

    private static MauiAppBuilder AddViews(this MauiAppBuilder builder)
    {
        builder.Services.TryAddTransient<MainPage>();
        builder.Services.TryAddTransient<InitialPage>();
        builder.Services.TryAddTransient<SettingsPage>();
        
        return builder;
    }

    private static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
    {
        builder.Services.TryAddTransient<MainPageViewModel>();
        builder.Services.TryAddTransient<InitialPageViewModel>();
        builder.Services.TryAddTransient<SettingsPageViewModel>();
        
        return builder;
    }

    private static MauiAppBuilder AddServices(this MauiAppBuilder builder)
    {
        return builder;
    }

    private static MauiAppBuilder ConfigureApplication(this MauiAppBuilder builder)
    {
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });
        
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder;
    }
}