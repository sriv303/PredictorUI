using Microsoft.Extensions.DependencyInjection;
using PredictorUI.Common;
using System.Windows.Forms.Design;

namespace PredictorUI
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureServices();

            // Get an instance of your main form from the service provider
           

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
            //var regForm = serviceProvider.GetRequiredService<RegisterForm>();
            //Application.Run(regForm);
        }

        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register your application's services here. For example:
            services.AddTransient<IDataService, DataService>();
            services.AddSingleton<LoginForm>();
            //services.AddSingleton<RegisterForm>();

            return services.BuildServiceProvider();
        }
    }
}