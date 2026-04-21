namespace UnoMaterialDesign.Presentation;

public partial class FieldsViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private string? _phone;

    [ObservableProperty]
    private string? _comment;

    [ObservableProperty]
    private string? _floatingHintText;

    [ObservableProperty]
    private string _multilineText = "Multiline. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. The quick brown fox jumps over the lazy dog.";

    [ObservableProperty]
    private string? _prefixSuffixText = "Good stuff";

    [ObservableProperty]
    private bool _filledTextEnabled = true;

    [ObservableProperty]
    private bool _filledPasswordEnabled = true;

    [ObservableProperty]
    private bool _outlinedTextEnabled = true;

    [ObservableProperty]
    private bool _outlinedCounterEnabled = true;

    [ObservableProperty]
    private bool _outlinedPasswordEnabled = true;

    [ObservableProperty]
    private string? _templateName = "Mr. Test";

    [ObservableProperty]
    private string? _templateContent;
}
