// File: Services/NotificationCacheService.cs
using System.Collections.ObjectModel;
using MauiNotificationPreview.Models;

namespace MauiNotificationPreview.Services;

public class NotificationCacheService
{
    public ObservableCollection<NotiPreview> Previews { get; } = new();

    public void AddNotification(string app, string title, string message)
    {
        Previews.Insert(0, new NotiPreview
        {
            App = app,
            Title = title,
            Message = message,
            Timestamp = DateTime.Now
        });

        // Limit to last 20 notifications
        if (Previews.Count > 20)
        {
            Previews.RemoveAt(Previews.Count - 1);
        }
    }

    public void Clear() => Previews.Clear();
}
