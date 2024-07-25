using Microsoft.Extensions.Logging;


namespace HomePageDifferentCardsPOC
{
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
				 .ConfigureMauiHandlers(h =>
				 {
#if ANDROID || IOS
					 h.AddHandler<CustomButton, CustomButtonHandler>();
#endif
				 });

#if DEBUG
			builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
