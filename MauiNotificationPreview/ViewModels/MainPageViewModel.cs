// File: ViewModels/MainPageViewModel.cs
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiNotificationPreview.model;

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
        // Mock data removed for production use.
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}