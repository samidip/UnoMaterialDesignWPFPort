namespace UnoMaterialDesign.Presentation;

public partial class CardsViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotFlipped))]
    private bool _isFlipped;

    public bool IsNotFlipped => !IsFlipped;

    [ObservableProperty]
    private bool _task1Done = true;

    [ObservableProperty]
    private bool _task2Done;

    [ObservableProperty]
    private bool _task3Done;

    [RelayCommand]
    private void ToggleFlip() => IsFlipped = !IsFlipped;
}
