namespace UnoMaterialDesign.Presentation;

public partial class ToolTipsViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isTeachingTipOpen;

    [ObservableProperty]
    private bool _isRichTipOpen;

    [ObservableProperty]
    private string _teachingTipMessage = "TeachingTip provides guided, contextual help anchored to a target element.";
}
