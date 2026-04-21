namespace UnoMaterialDesign.Presentation;

public sealed partial class DrawersPage : Page
{
    public DrawersPage()
    {
        this.InitializeComponent();
    }

    private void OpenLeftDrawer_Click(object sender, RoutedEventArgs e) =>
        LeftDrawer.IsOpen = true;

    private void CloseLeftDrawer_Click(object sender, RoutedEventArgs e) =>
        LeftDrawer.IsOpen = false;

    private void OpenRightDrawer_Click(object sender, RoutedEventArgs e) =>
        RightDrawer.IsOpen = true;

    private void CloseRightDrawer_Click(object sender, RoutedEventArgs e) =>
        RightDrawer.IsOpen = false;

    private void OpenTopDrawer_Click(object sender, RoutedEventArgs e) =>
        TopDrawerOverlay.Visibility = Visibility.Visible;

    private void CloseTopDrawer_Click(object sender, RoutedEventArgs e) =>
        TopDrawerOverlay.Visibility = Visibility.Collapsed;

    private void OpenBottomDrawer_Click(object sender, RoutedEventArgs e) =>
        BottomDrawerOverlay.Visibility = Visibility.Visible;

    private void CloseBottomDrawer_Click(object sender, RoutedEventArgs e) =>
        BottomDrawerOverlay.Visibility = Visibility.Collapsed;

    private void OpenSplitView_Click(object sender, RoutedEventArgs e) =>
        DemoSplitView.IsPaneOpen = true;

    private void CloseSplitView_Click(object sender, RoutedEventArgs e) =>
        DemoSplitView.IsPaneOpen = false;
}
