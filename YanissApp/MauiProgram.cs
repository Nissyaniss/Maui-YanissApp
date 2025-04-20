using Microsoft.Extensions.Logging;
using YanissApp.Services;
using YanissApp.ViewModels;
using YanissApp.Views;

namespace YanissApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers(handlers => {})
			.Logging.AddDebug();

#if DEBUG
		builder.Logging.AddDebug();
		builder.Services.AddTransient<JokeDetailViewModel>();
		builder.Services.AddSingleton<IJokeService, JokeService>();
		builder.Services.AddTransient<JokeListViewModel>();
		builder.Services.AddTransient<ListPage>();
		builder.Services.AddTransient<JokeDetailPage>();
		builder.Services.AddTransient<AddJokeViewModel>();
		builder.Services.AddTransient<AddPage>();
		builder.Services.AddTransient<ToolPageViewModel>();
		builder.Services.AddTransient<ToolPage>();

#endif

		var app = builder.Build();
		return app;
	}
}
