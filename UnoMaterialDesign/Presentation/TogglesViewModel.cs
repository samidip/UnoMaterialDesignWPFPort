namespace UnoMaterialDesign.Presentation;

public partial class TogglesViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _wifiEnabled = true;

    [ObservableProperty]
    private bool _bluetoothEnabled;

    [ObservableProperty]
    private bool _airplaneMode;

    [ObservableProperty]
    private bool _isBold;

    [ObservableProperty]
    private bool _isItalic;

    [ObservableProperty]
    private bool _isUnderline;

    [ObservableProperty]
    private bool _notificationsEnabled = true;

    [ObservableProperty]
    private bool _soundEnabled = true;

    [ObservableProperty]
    private bool _vibrationEnabled;
}
