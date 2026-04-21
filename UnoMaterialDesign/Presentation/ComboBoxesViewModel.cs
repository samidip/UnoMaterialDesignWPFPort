namespace UnoMaterialDesign.Presentation;

public partial class ComboBoxesViewModel : ObservableObject
{
    [ObservableProperty]
    private int? _selectedValueOne;

    [ObservableProperty]
    private string? _selectedTextTwo;

    [ObservableProperty]
    private string? _selectedFruit;

    [ObservableProperty]
    private bool _showSelectedInDropDown;

    [ObservableProperty]
    private bool _filledEnabled = true;

    [ObservableProperty]
    private string? _selectedFilledItem;

    [ObservableProperty]
    private bool _outlinedEnabled = true;

    [ObservableProperty]
    private string? _selectedOutlinedItem;

    [ObservableProperty]
    private string? _selectedValidation;

    public ComboBoxesViewModel()
    {
        LongIntegerList = new List<int>(Enumerable.Range(0, 1000));
        ShortStringList = ["Item 1", "Item 2", "Item 3"];
        FruitList = ["Apple", "Banana", "Pear", "Orange"];
        OsList = ["Android", "iOS", "Linux", "Windows"];

        SelectedValueOne = LongIntegerList.Skip(2).First();
    }

    public IList<int> LongIntegerList { get; }
    public IList<string> ShortStringList { get; }
    public IList<string> FruitList { get; }
    public IList<string> OsList { get; }

    [RelayCommand]
    private void ClearFilledSelection() => SelectedFilledItem = null;

    [RelayCommand]
    private void ClearOutlinedSelection() => SelectedOutlinedItem = null;
}
