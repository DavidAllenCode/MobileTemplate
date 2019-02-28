using MobileProject.Constants;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProject.ViewModels
{
    public class LoginPageViewModel : PageViewModelBase
    {
        //private INavigationService _navigationService;
        private string username;
        private string password;
        private readonly DelegateCommand loginCommand;

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            //this._navigationService = navigationService;
            this.loginCommand = new DelegateCommand(async () => await this.LoginAsync());
        }

        public string Username
        {
            get { return this.username; }
            set { this.SetProperty(ref this.username, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { this.SetProperty(ref this.password, value); }
        }


        public DelegateCommand LoginCommand => loginCommand;

        private async Task LoginAsync()
        {
            NavigationParameters parms = new NavigationParameters();
            parms.Add(HomePageViewModel.NavParameters.Username, this.Username);
            await this.NavigateSafeAsync(NavigationKeys.HomePage, parms);
        }
    }
}
