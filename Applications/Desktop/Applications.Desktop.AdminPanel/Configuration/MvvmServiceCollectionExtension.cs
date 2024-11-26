using Applications.Desktop.AdminPanel.ViewModels;
using Applications.Desktop.AdminPanel.ViewModels.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace Applications.Desktop.AdminPanel.Configuration;

public static class MvvmServiceCollectionExtension
{
    public static void RegisterViews(this ServiceCollection services)
    {
        services.AddScoped<LoginWindow>();
    }

    public static void RegisterViewModels(this ServiceCollection services)
    {
        services.AddScoped<ILoginViewModel, LoginViewModel>();
    }
}
