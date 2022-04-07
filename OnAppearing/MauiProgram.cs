namespace OnAppearing;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => {
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient<Page1>();
		builder.Services.AddTransient<Page2>();
		builder.Services.AddTransient<Page3>();

		return builder.Build();
	}
}
