namespace CloudyCrashReporting.ClientApp;

public partial class App : Application
{
	public App(ICrashReporterProvider provider)
	{
		InitializeComponent();
		var page = IPlatformApplication.Current!.Services.GetService<MainPage>();
		//NavigationPage nav = new NavigationPage(page);

		MainPage = new AppShell();
		//MainPage = page;
		provider.Init();
	}
}