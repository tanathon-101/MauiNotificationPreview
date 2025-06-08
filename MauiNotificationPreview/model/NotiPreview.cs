// File: model/NotiPreview.cs
namespace MauiNotificationPreview.Models;

public class NotiPreview
{
    public string App { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}
