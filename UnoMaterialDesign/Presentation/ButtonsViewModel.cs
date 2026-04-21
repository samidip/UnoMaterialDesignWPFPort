namespace UnoMaterialDesign.Presentation;

public partial class ButtonsViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _controlsEnabled = true;

    [ObservableProperty]
    private int _clickCount;

    [RelayCommand]
    private void IncrementClickCount() => ClickCount++;

    [RelayCommand]
    private void ResetClickCount() => ClickCount = 0;
}
