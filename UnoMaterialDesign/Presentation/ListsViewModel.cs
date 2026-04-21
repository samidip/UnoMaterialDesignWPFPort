using System.Collections.ObjectModel;

namespace UnoMaterialDesign.Presentation;

public partial class ListsViewModel : ObservableObject
{
    public ListsViewModel()
    {
        SimpleItems = ["Plain", "Old", "ListView", "Full of items"];
        ProjectItems =
        [
            new ProjectItem('M', "Material Design", "Material Design in XAML Toolkit"),
            new ProjectItem('D', "Dragablz", "Dragablz Tab Control"),
            new ProjectItem('P', "Predator", "If it bleeds, we can kill it"),
        ];
        CheckableItems = new ObservableCollection<CheckableItem>(
        [
            new CheckableItem("Material Design", "Material Design in XAML Toolkit", true),
            new CheckableItem("Dragablz", "Dragablz Tab Control", false),
            new CheckableItem("Predator", "If it bleeds, we can kill it", false),
        ]);
        GridItems =
        [
            new GridRowItem("M", "Material Design", "UI toolkit for WPF & Uno"),
            new GridRowItem("D", "Dragablz", "Tab control with docking"),
            new GridRowItem("P", "Predator", "Classic 1987 film"),
            new GridRowItem("U", "Uno Platform", "Cross-platform with C# & XAML"),
        ];
    }

    public List<string> SimpleItems { get; }
    public List<ProjectItem> ProjectItems { get; }
    public ObservableCollection<CheckableItem> CheckableItems { get; }
    public List<GridRowItem> GridItems { get; }

    [ObservableProperty]
    private bool _listEnabled = true;

    [ObservableProperty]
    private string? _selectedSimpleItem;

    [ObservableProperty]
    private ProjectItem? _selectedProject;
}

public record ProjectItem(char Code, string Name, string Description);

public record GridRowItem(string Code, string Name, string Description);

public partial class CheckableItem : ObservableObject
{
    public CheckableItem(string name, string description, bool isSelected)
    {
        _name = name;
        _description = description;
        _isChecked = isSelected;
    }

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private bool _isChecked;
}
