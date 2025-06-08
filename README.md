# MauiNotificationPreview

A .NET MAUI Android app to preview notifications (e.g., LINE, Instagram) without opening the original app.  
Built for S23 Ultra with ZXing & NotificationListenerService.

## Features

- Preview notifications from LINE, Instagram, and more without opening the original app
- Fast notification reading (Android only)
- Supports .NET MAUI cross-platform framework

## Installation

1. Clone this repository:
    ```sh
    git clone https://github.com/tanathon-101/MauiNotificationPreview.git
    ```
2. Open the project in Visual Studio 2022+ with MAUI workload installed.
3. Build and deploy to your Android device.

## Usage

- Grant Notification Listener permission to the app after first launch.
- The app will display incoming notifications from supported apps.

## Supported Platforms

- **Android:** Full notification preview support
- **Other Platforms (iOS, Windows, Mac, Tizen):** App will alert that notification preview feature is not available

## Screenshots

_Add your screenshots here!_

## Privacy

This app does not collect or send any notification data externally. All data is processed locally on your device.

## License

MIT
