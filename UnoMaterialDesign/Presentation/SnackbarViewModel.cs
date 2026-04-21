namespace UnoMaterialDesign.Presentation;

public partial class SnackbarViewModel : ObservableObject
{
    [ObservableProperty]
    private string _messageText = "Hello World";

    [ObservableProperty]
    private string _snackbarText = string.Empty;

    [ObservableProperty]
    private bool _isSnackbarVisible;

    [ObservableProperty]
    private double _durationSeconds = 3.0;

    [ObservableProperty]
    private int _messageCount;
}
