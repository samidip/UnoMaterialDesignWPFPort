using System.Collections.ObjectModel;

namespace UnoMaterialDesign.Presentation;

public partial class DialogsViewModel : ObservableObject
{
    public DialogsViewModel()
    {
        Fruits = new ObservableCollection<string>(["Apple", "Banana", "Pear"]);
        Animals = new ObservableCollection<string>(["Dog", "Cat", "Platypus"]);
    }

    public ObservableCollection<string> Fruits { get; }
    public ObservableCollection<string> Animals { get; }

    [ObservableProperty]
    private string _dialogResult = "No dialog shown yet.";

    [ObservableProperty]
    private string _newFruit = string.Empty;

    [ObservableProperty]
    private string _newAnimal = string.Empty;
}
