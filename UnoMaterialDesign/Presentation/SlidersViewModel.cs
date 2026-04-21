namespace UnoMaterialDesign.Presentation;

public partial class SlidersViewModel : ObservableObject
{
    [ObservableProperty]
    private double _continuousValue = 35;

    [ObservableProperty]
    private double _tickedValue = 10;

    [ObservableProperty]
    private double _disabledValue = 25;

    [ObservableProperty]
    private double _discreteMax = 100;

    [ObservableProperty]
    private double _discreteTick = 10;

    [ObservableProperty]
    private double _discreteValue = 40;

    [ObservableProperty]
    private double _discreteVertMax = 100000;

    [ObservableProperty]
    private double _discreteVertTick = 10000;

    [ObservableProperty]
    private double _discreteVertValue = 70000;

    [ObservableProperty]
    private double _interactiveValue = 50;

    [ObservableProperty]
    private bool _sliderEnabled = true;
}
