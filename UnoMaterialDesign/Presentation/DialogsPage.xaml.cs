namespace UnoMaterialDesign.Presentation;

public sealed partial class DialogsPage : Page
{
    public DialogsPage()
    {
        this.InitializeComponent();
    }

    private DialogsViewModel? ViewModel => DataContext as DialogsViewModel;

    private async void ShowBasicDialog_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new ContentDialog
        {
            Title = "Basic Dialog",
            Content = "This is a simple informational dialog with a single close button.",
            CloseButtonText = "OK",
            XamlRoot = this.XamlRoot,
        };

        var result = await dialog.ShowAsync();
        if (ViewModel is { } vm)
            vm.DialogResult = $"Basic dialog closed: {result}";
    }

    private async void ShowConfirmDialog_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new ContentDialog
        {
            Title = "Confirm Action",
            Content = "Are you sure you want to proceed? This action cannot be undone.",
            PrimaryButtonText = "Confirm",
            SecondaryButtonText = "Cancel",
            CloseButtonText = "Dismiss",
            DefaultButton = ContentDialogButton.Primary,
            XamlRoot = this.XamlRoot,
        };

        var result = await dialog.ShowAsync();
        if (ViewModel is { } vm)
            vm.DialogResult = $"Confirm dialog result: {result}";
    }

    private async void ShowAddFruitDialog_Click(object sender, RoutedEventArgs e)
    {
        var textBox = new TextBox
        {
            PlaceholderText = "Enter a fruit name",
            Style = (Style)Application.Current.Resources["FilledTextBoxStyle"],
        };

        var dialog = new ContentDialog
        {
            Title = "Add a New Fruit",
            Content = textBox,
            PrimaryButtonText = "Add",
            CloseButtonText = "Cancel",
            DefaultButton = ContentDialogButton.Primary,
            XamlRoot = this.XamlRoot,
        };

        var result = await dialog.ShowAsync();
        if (result == ContentDialogResult.Primary
            && !string.IsNullOrWhiteSpace(textBox.Text)
            && ViewModel is { } vm)
        {
            vm.Fruits.Add(textBox.Text.Trim());
            vm.DialogResult = $"Added fruit: {textBox.Text.Trim()}";
        }
    }

    private async void ShowAddAnimalDialog_Click(object sender, RoutedEventArgs e)
    {
        var textBox = new TextBox
        {
            PlaceholderText = "Enter an animal name",
            Style = (Style)Application.Current.Resources["FilledTextBoxStyle"],
        };

        var dialog = new ContentDialog
        {
            Title = "Add a New Animal",
            Content = textBox,
            PrimaryButtonText = "Add",
            CloseButtonText = "Cancel",
            DefaultButton = ContentDialogButton.Primary,
            XamlRoot = this.XamlRoot,
        };

        var result = await dialog.ShowAsync();
        if (result == ContentDialogResult.Primary
            && !string.IsNullOrWhiteSpace(textBox.Text)
            && ViewModel is { } vm)
        {
            vm.Animals.Add(textBox.Text.Trim());
            vm.DialogResult = $"Added animal: {textBox.Text.Trim()}";
        }
    }

    private async void ShowCustomContentDialog_Click(object sender, RoutedEventArgs e)
    {
        var content = new StackPanel { Spacing = 16 };
        content.Children.Add(new TextBlock
        {
            Text = "This dialog demonstrates rich custom content inside a ContentDialog.",
            TextWrapping = TextWrapping.Wrap,
        });
        content.Children.Add(new ProgressBar { IsIndeterminate = true });
        content.Children.Add(new TextBlock
        {
            Text = "A progress bar is shown above as an example of embedded controls.",
            TextWrapping = TextWrapping.Wrap,
            Opacity = 0.7,
        });

        var dialog = new ContentDialog
        {
            Title = "Custom Content",
            Content = content,
            PrimaryButtonText = "Accept",
            SecondaryButtonText = "Decline",
            CloseButtonText = "Close",
            XamlRoot = this.XamlRoot,
        };

        var result = await dialog.ShowAsync();
        if (ViewModel is { } vm)
            vm.DialogResult = $"Custom dialog result: {result}";
    }
}
