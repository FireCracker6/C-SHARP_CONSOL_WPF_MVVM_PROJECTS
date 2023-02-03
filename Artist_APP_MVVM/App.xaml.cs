using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Artist_APP_MVVM.MVVM.ViewModels;
using Artist_APP_MVVM.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Artist_APP_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost app { get; private set; }

        public App()
        {
            app = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<NavigationStore>();
                services.AddSingleton<ArtistService>();

            }).Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var artistService = app!.Services.GetRequiredService<ArtistService>();
            var navigationStore = app!.Services.GetRequiredService<NavigationStore>();
            navigationStore.CurrentViewModel = new ArtistsViewModel(navigationStore ,artistService);
           

            app.Start();

            var MainVindow = app.Services.GetRequiredService<MainWindow>();
            MainWindow.DataContext = new MainViewModel(navigationStore);
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
