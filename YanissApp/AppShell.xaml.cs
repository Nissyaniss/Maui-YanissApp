using YanissApp.Views;

namespace YanissApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(GifPage), typeof(GifPage));
		Routing.RegisterRoute(nameof(JokeDetailPage), typeof(JokeDetailPage));
		Routing.RegisterRoute(nameof(ListPage), typeof(ListPage));
		Routing.RegisterRoute(nameof(ExpensesPage), typeof(ExpensesPage));
		Routing.RegisterRoute(nameof(CitationPage), typeof(CitationPage));
		
	}
}
