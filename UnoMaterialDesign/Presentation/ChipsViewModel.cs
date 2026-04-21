using System.Collections.ObjectModel;

namespace UnoMaterialDesign.Presentation;

public partial class ChipsViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _selectedPlanet;

    [ObservableProperty]
    private string? _chipMessage;

    public ChipsViewModel()
    {
        Planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter"];
        Fruits = ["Apple", "Banana", "Cherry", "Date", "Elderberry"];
        Tags = new ObservableCollection<string>(["Design", "Code", "Test", "Deploy", "Monitor"]);
    }

    public IList<string> Planets { get; }
    public IList<string> Fruits { get; }
    public ObservableCollection<string> Tags { get; }

    [RelayCommand]
    private void ChipClicked(string chipName)
        => ChipMessage = $"Chip clicked: {chipName}";

    [RelayCommand]
    private void RemoveTag(string tag)
    {
        Tags.Remove(tag);
        ChipMessage = $"Removed: {tag}";
    }
}
