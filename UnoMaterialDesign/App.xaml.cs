using System.Diagnostics.CodeAnalysis;
using Uno.Resizetizer;

namespace UnoMaterialDesign;

public partial class App : Application
{
    /// <summary>
    /// Initializes the singleton application object. This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        this.InitializeComponent();
    }

    protected Window? MainWindow { get; private set; }
    protected IHost? Host { get; private set; }

    [SuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "Uno.Extensions APIs are used in a way that is safe for trimming in this template context.")]
    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        var builder = this.CreateBuilder(args)
            // Add navigation support for toolkit controls such as TabBar and NavigationView
            .UseToolkitNavigation()
            .Configure(host => host
#if DEBUG
                // Switch to Development environment when running in DEBUG
                .UseEnvironment(Environments.Development)
#endif
                .UseLogging(configure: (context, logBuilder) =>
                {
                    // Configure log levels for different categories of logging
                    logBuilder
                        .SetMinimumLevel(
                            context.HostingEnvironment.IsDevelopment() ?
                                LogLevel.Information :
                                LogLevel.Warning)

                        // Default filters for core Uno Platform namespaces
                        .CoreLogLevel(LogLevel.Warning);

                    // Uno Platform namespace filter groups
                    // Uncomment individual methods to see more detailed logging
                    //// Generic Xaml events
                    //logBuilder.XamlLogLevel(LogLevel.Debug);
                    //// Layout specific messages
                    //logBuilder.XamlLayoutLogLevel(LogLevel.Debug);
                    //// Storage messages
                    //logBuilder.StorageLogLevel(LogLevel.Debug);
                    //// Binding related messages
                    //logBuilder.XamlBindingLogLevel(LogLevel.Debug);
                    //// Binder memory references tracking
                    //logBuilder.BinderMemoryReferenceLogLevel(LogLevel.Debug);
                    //// DevServer and HotReload related
                    //logBuilder.HotReloadCoreLogLevel(LogLevel.Information);
                    //// Debug JS interop
                    //logBuilder.WebAssemblyLogLevel(LogLevel.Debug);

                }, enableUnoLogging: true)
                .UseConfiguration(configure: configBuilder =>
                    configBuilder
                        .EmbeddedSource<App>()
                        .Section<AppConfig>()
                )
                // Enable localization (see appsettings.json for supported languages)
                .UseLocalization()
                .ConfigureServices((context, services) =>
                {
                    // TODO: Register your services
                    //services.AddSingleton<IMyService, MyService>();
                })
                .UseNavigation(RegisterRoutes)
            );
        MainWindow = builder.Window;

#if DEBUG
        MainWindow.UseStudio();
#endif
        MainWindow.SetWindowIcon();

        Host = await builder.NavigateAsync<Shell>();
    }

    private static void RegisterRoutes(IViewRegistry views, IRouteRegistry routes)
    {
        views.Register(
            new ViewMap(ViewModel: typeof(ShellViewModel)),
            new ViewMap<MainPage, MainViewModel>(),
            new ViewMap<HomePage, HomeViewModel>(),
            new ViewMap<ButtonsPage, ButtonsViewModel>(),
            new ViewMap<CardsPage, CardsViewModel>(),
            new ViewMap<TogglesPage, TogglesViewModel>(),
            new ViewMap<FieldsPage, FieldsViewModel>(),
            new ViewMap<ComboBoxesPage, ComboBoxesViewModel>(),
            new ViewMap<PickersPage, PickersViewModel>(),
            new ViewMap<SlidersPage, SlidersViewModel>(),
            new ViewMap<ChipsPage, ChipsViewModel>(),
            new ViewMap<TypographyPage, TypographyViewModel>(),
            new ViewMap<ProgressPage, ProgressViewModel>(),
            new ViewMap<DialogsPage, DialogsViewModel>(),
            new ViewMap<ElevationPage, ElevationViewModel>(),
            new ViewMap<ListsPage, ListsViewModel>(),
            new ViewMap<TreesPage, TreesViewModel>(),
            new ViewMap<ExpanderPage, ExpanderViewModel>(),
            new ViewMap<MenusPage, MenusViewModel>(),
            new ViewMap<SnackbarPage, SnackbarViewModel>(),
            new ViewMap<ToolTipsPage, ToolTipsViewModel>(),
            new ViewMap<DrawersPage, DrawersViewModel>()
        );

        routes.Register(
            new RouteMap("", View: views.FindByViewModel<ShellViewModel>(),
                Nested:
                [
                    new RouteMap("Main", View: views.FindByViewModel<MainViewModel>(), IsDefault: true,
                        Nested:
                        [
                            new RouteMap("Home", View: views.FindByViewModel<HomeViewModel>(), IsDefault: true),
                            new RouteMap("Buttons", View: views.FindByViewModel<ButtonsViewModel>()),
                            new RouteMap("Cards", View: views.FindByViewModel<CardsViewModel>()),
                            new RouteMap("Toggles", View: views.FindByViewModel<TogglesViewModel>()),
                            new RouteMap("Fields", View: views.FindByViewModel<FieldsViewModel>()),
                            new RouteMap("ComboBoxes", View: views.FindByViewModel<ComboBoxesViewModel>()),
                            new RouteMap("Pickers", View: views.FindByViewModel<PickersViewModel>()),
                            new RouteMap("Sliders", View: views.FindByViewModel<SlidersViewModel>()),
                            new RouteMap("Chips", View: views.FindByViewModel<ChipsViewModel>()),
                            new RouteMap("Typography", View: views.FindByViewModel<TypographyViewModel>()),
                            new RouteMap("Progress", View: views.FindByViewModel<ProgressViewModel>()),
                            new RouteMap("Dialogs", View: views.FindByViewModel<DialogsViewModel>()),
                            new RouteMap("Elevation", View: views.FindByViewModel<ElevationViewModel>()),
                            new RouteMap("Lists", View: views.FindByViewModel<ListsViewModel>()),
                            new RouteMap("Trees", View: views.FindByViewModel<TreesViewModel>()),
                            new RouteMap("Expander", View: views.FindByViewModel<ExpanderViewModel>()),
                            new RouteMap("Menus", View: views.FindByViewModel<MenusViewModel>()),
                            new RouteMap("Snackbar", View: views.FindByViewModel<SnackbarViewModel>()),
                            new RouteMap("ToolTips", View: views.FindByViewModel<ToolTipsViewModel>()),
                            new RouteMap("Drawers", View: views.FindByViewModel<DrawersViewModel>()),
                        ])
                ]
            )
        );
    }
}
