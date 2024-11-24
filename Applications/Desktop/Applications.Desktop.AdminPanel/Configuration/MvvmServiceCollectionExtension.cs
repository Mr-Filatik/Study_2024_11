using Applications.Desktop.AdminPanel.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Desktop.AdminPanel.Configuration;

public static class MvvmServiceCollectionExtension
{
    public static void RegisterViews(this IServiceCollection services)
    {
        services.AddScoped<LoginWindow>();
    }

    public static void RegisterViewModels(this IServiceCollection services)
    {
        services.AddScoped<ILoginViewModel, LoginViewModel>();
    }
}
