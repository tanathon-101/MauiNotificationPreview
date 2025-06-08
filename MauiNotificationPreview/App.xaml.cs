// File: App.xaml.cs
namespace MauiNotificationPreview;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell(); // ✅ ใช้ Shell เป็น root layout
    }
}
