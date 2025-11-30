namespace MarkMobileMechanic.Maui;

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
            });

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<Views.HomePage>();
        builder.Services.AddSingleton<Views.ServicesListPage>();
        builder.Services.AddSingleton<Views.BookingsPage>();
        builder.Services.AddSingleton<Views.VehiclesPage>();
        builder.Services.AddSingleton<Views.WorkOrdersPage>();

        builder.Services.AddSingleton<ViewModels.HomeViewModel>();
        builder.Services.AddSingleton<ViewModels.ServicesListViewModel>();
        builder.Services.AddSingleton<ViewModels.BookingsViewModel>();
        builder.Services.AddSingleton<ViewModels.VehiclesViewModel>();
        builder.Services.AddSingleton<ViewModels.WorkOrdersViewModel>();

        return builder.Build();
    }
}
