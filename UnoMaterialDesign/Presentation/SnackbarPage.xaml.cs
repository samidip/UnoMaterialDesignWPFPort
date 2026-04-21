namespace UnoMaterialDesign.Presentation;

public sealed partial class SnackbarPage : Page
{
    private DispatcherTimer? _snackbarTimer;

    public SnackbarPage()
    {
        this.InitializeComponent();
    }

    private SnackbarViewModel? ViewModel => DataContext as SnackbarViewModel;

    private void ShowSnackbar(string message, double durationSeconds = 3.0)
    {
        if (ViewModel is not { } vm) return;

        vm.SnackbarText = message;
        vm.IsSnackbarVisible = true;
        vm.MessageCount++;

        _snackbarTimer?.Stop();
        _snackbarTimer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(durationSeconds) };
        _snackbarTimer.Tick += (_, _) =>
        {
            vm.IsSnackbarVisible = false;
            _snackbarTimer.Stop();
        };
        _snackbarTimer.Start();
    }

    private void SendMessage_Click(object sender, RoutedEventArgs e)
    {
        if (ViewModel is { } vm && !string.IsNullOrWhiteSpace(vm.MessageText))
            ShowSnackbar(vm.MessageText, vm.DurationSeconds);
    }

    private void ShowSimple_Click(object sender, RoutedEventArgs e)
        => ShowSnackbar("This is a simple snackbar notification.");

    private void ShowWithAction_Click(object sender, RoutedEventArgs e)
        => ShowSnackbar("Item deleted. Tap UNDO to restore.", 5.0);

    private void ShowLong_Click(object sender, RoutedEventArgs e)
        => ShowSnackbar("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 6.0);

    private void DismissSnackbar_Click(object sender, RoutedEventArgs e)
    {
        if (ViewModel is { } vm)
        {
            vm.IsSnackbarVisible = false;
            _snackbarTimer?.Stop();
        }
    }

    private void UndoAction_Click(object sender, RoutedEventArgs e)
    {
        if (ViewModel is { } vm)
        {
            vm.IsSnackbarVisible = false;
            _snackbarTimer?.Stop();
            ShowSnackbar("Action undone!", 2.0);
        }
    }
}
