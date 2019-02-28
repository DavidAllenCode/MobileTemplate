using Prism;
using Prism.Ioc;
using MobileProject.ViewModels;
using MobileProject.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using Prism.Navigation;
using MobileProject.Constants;
using MobileProject.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileProject
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */

        private INavigationService rootNavService;

        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
            //var rootPage = (NavigationPage)this.MainPage;
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            this.NavigationService.NavigateAsync($"{NavigationKeys.CustomNavigationPage}/{NavigationKeys.LoginPage}");
            //this.NavigationService.NavigateAsync(NavigationKeys.LoginPage);
            Plugin.Connectivity.CrossConnectivity.Current.ConnectivityChanged += this.HandleConnectivityChanged;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>(NavigationKeys.LoginPage);
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>(NavigationKeys.HomePage);
            containerRegistry.RegisterForNavigation<CustomNavigationPage>(NavigationKeys.CustomNavigationPage);
        }

        private async void HandleConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            //if (e.IsConnected && CheckConnectionPage.IsPageVisible)
            //{
            //    await this.NavigationService.GoBackAsync(useModalNavigation: true);
            //}
            //else if (!e.IsConnected && !CheckConnectionPage.IsPageVisible)
            //{
            //    await this.NavigationService.NavigateAsync(NavigationKeys.NoConnectionPage, useModalNavigation: true);
            //}
        }
    }
}
