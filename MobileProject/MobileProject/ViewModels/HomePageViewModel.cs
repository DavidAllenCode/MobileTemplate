using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MobileProject.ViewModels
{
    public class HomePageViewModel : PageViewModelBase
    {
        //private INavigationService _navigationService;
        public DelegateCommand NavigateToSpeakPageCommand { get; private set; }
        private string username;

        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            //_navigationService = navigationService;
            NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
        }

        private void NavigateToSpeakPage()
        {
            //_navigationService.NavigateAsync("SpeakPage");
        }

        public string Username
        {
            get { return this.username; }
            set { this.SetProperty(ref this.username, value); }
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            if (parameters.TryGetValue(NavParameters.Username, out string user))
            {
                this.Username = user;
            }
        }

        public static class NavParameters
        {
            public const string FirstName = "FirstName";
            public const string LastName = "LastName";
            public const string Username = "Username";
        }
    }
}
