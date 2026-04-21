namespace UnoMaterialDesign.Presentation;

public partial class ProgressViewModel : ObservableObject
{
    [ObservableProperty]
    private double _determinateValue = 35;

    [ObservableProperty]
    private double _secondValue = 70;

    [ObservableProperty]
    private bool _isIndeterminate;

    [ObservableProperty]
    private bool _progressEnabled = true;
}
