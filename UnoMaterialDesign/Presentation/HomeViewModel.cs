namespace UnoMaterialDesign.Presentation;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(AreFabsCollapsed))]
    private bool _areFabsExpanded = true;

    public bool AreFabsCollapsed => !AreFabsExpanded;

    [RelayCommand]
    private void ToggleFabs() => AreFabsExpanded = !AreFabsExpanded;

    [RelayCommand]
    private async Task OpenGitHub()
        => await Launcher.LaunchUriAsync(new Uri("https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit"));

    [RelayCommand]
    private async Task OpenTwitter()
        => await Launcher.LaunchUriAsync(new Uri("https://twitter.com/James_Willock"));

    [RelayCommand]
    private async Task OpenChat()
        => await Launcher.LaunchUriAsync(new Uri("https://gitter.im/ButchersBoy/MaterialDesignInXamlToolkit"));

    [RelayCommand]
    private async Task OpenEmail()
        => await Launcher.LaunchUriAsync(new Uri("mailto:james@dragablz.net"));

    [RelayCommand]
    private async Task OpenDonate()
        => await Launcher.LaunchUriAsync(new Uri("https://opencollective.com/materialdesigninxaml"));
}
