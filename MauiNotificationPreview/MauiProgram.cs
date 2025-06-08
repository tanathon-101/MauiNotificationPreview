// File: MauiProgram.cs
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MauiNotificationPreview.Services;
using MauiNotificationPreview.ViewModels;

namespace MauiNotificationPreview;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Register services
        builder.Services.AddSingleton<NotificationCacheService>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<MainPage>();

        var app = builder.Build();

#if ANDROID
        // เชื่อม instance ให้ Android platform ใช้ static push noti ได้
        var service = app.Services.GetService<NotificationCacheService>();
        MauiNotificationPreview.Platforms.Android.NotificationCacheServiceStatic.Instance = service;
#endif

        return app;
    }
}
