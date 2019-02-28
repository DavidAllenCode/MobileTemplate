using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileProject.ViewModels
{
    public class PageViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        //protected INavigationService NavigationService { get; private set; }

        private readonly INavigationService navigationService;

        private readonly DelegateCommand navigateBackCommand;


        public PageViewModelBase(INavigationService navigationService)
        {
            // Services
            this.navigationService = navigationService;

            //Commands
            this.navigateBackCommand = new DelegateCommand(async () => { await this.NavigateSafeAsync(navigationMode: NavigationMode.Back); });

        }

        public DelegateCommand NavigateBackCommand => this.navigateBackCommand;


        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        /// <summary>
        /// Navigates and tracks exceptions generated.
        /// </summary>
        /// <returns>Bool to indicate whether navigation was successful.</returns>
        /// <param name="name">Key for navigation.</param>
        /// <param name="parameters">Parameters.</param>
        /// <param name="useModalNavigation">Passed through to navigation</param>
        /// <param name="animated">Passed through to navigation</param>
        /// <param name="throwExceptions">Passed through to analytics</param>
        /// <param name="navigationMode">Passed through to Navigation Service</param>
        /// <param name="sendClaimContext">Indicates whether the claim context on this VM should be sent to the new VM</param>
        /// <param name="track">Indicates whether this navigation event should be tracked in analytics</param>
        protected async Task NavigateSafeAsync(
            string name = null,
            NavigationParameters parameters = null,
            bool? useModalNavigation = null,
            bool animated = true,
            bool throwExceptions = false,
            NavigationMode navigationMode = NavigationMode.New,
            bool sendClaimContext = true,
            bool track = true)
        {
            if (navigationMode.Equals(NavigationMode.New))
            {
                await this.navigationService.NavigateAsync(name, parameters, useModalNavigation, animated);
            }
            else if (navigationMode.Equals(NavigationMode.Back))
            {
                await this.navigationService.GoBackAsync(parameters, useModalNavigation, animated);
            }
        }

        public virtual void Destroy()
        {

        }
    }
}
