// File: Platforms/Android/NotifReaderService.cs
using Android.Service.Notification;
using Android.App;
using Android.Content;
using Android.OS;
using MauiNotificationPreview.Services;

namespace MauiNotificationPreview.Platforms.Android
{
    [Service(Label = "NotifReader", Permission = "android.permission.BIND_NOTIFICATION_LISTENER_SERVICE")]
    [IntentFilter(new[] { "android.service.notification.NotificationListenerService" })]
    public class NotifReaderService : NotificationListenerService
    {
        public override void OnNotificationPosted(StatusBarNotification sbn)
        {
            var extras = sbn.Notification.Extras;
            string? pkg = sbn.PackageName;
            string? title = extras?.GetCharSequence("android.title")?.ToString();
            string? text = extras?.GetCharSequence("android.text")?.ToString();

            if (string.IsNullOrWhiteSpace(text)) return;

            string app = pkg switch
            {
                "jp.naver.line.android" => "LINE",
                "com.instagram.android" => "Instagram",
                _ => pkg
            };

            // ⚠️ Static call to NotificationCacheService (or use MessagingCenter)
            NotificationCacheServiceStatic.Instance?.AddNotification(app, title ?? "(ไม่มีชื่อ)", text);
        }

        public override void OnNotificationRemoved(StatusBarNotification sbn)
        {
            // ไม่จำเป็นต้องทำอะไร
        }
    }

    // ใช้ static singleton (ชั่วคราว) ให้ Android ฝั่ง native ส่งเข้าไปยัง Service ได้
    public static class NotificationCacheServiceStatic
    {
        public static NotificationCacheService? Instance { get; set; }
    }
}
