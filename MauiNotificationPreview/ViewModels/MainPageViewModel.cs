// File: ViewModels/MainPageViewModel.cs
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiNotificationPreview.Models;

namespace MauiNotificationPreview.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{
    private ObservableCollection<NotiPreview> _previews = new();

    public ObservableCollection<NotiPreview> Previews
    {
        get => _previews;
        set
        {
            _previews = value;
            OnPropertyChanged();
        }
    }

    public MainPageViewModel()
    {
        // ตัวอย่าง noti mock
        Previews.Add(new NotiPreview { App = "LINE", Title = "Alice", Message = "ไปกินข้าวกันไหม?", Timestamp = DateTime.Now });
        Previews.Add(new NotiPreview { App = "Instagram", Title = "Bob", Message = "ส่ง Reel มาให้คุณ", Timestamp = DateTime.Now.AddMinutes(-10) });
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
