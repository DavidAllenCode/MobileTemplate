using System;
using System.Threading.Tasks;

namespace MobileProject.Abstractions
{
    /// <summary>
    /// A service that handles data transfer for this app
    /// </summary>
    internal interface IAppDataService : IDisposable
    {
        //Task<User> GetCachedUserAsync();

        //Task<HttpResponse<EmployerCustomSplash>> GetEmployerCustomSplashAsync();

        //Task<string> GetLocalValueForUser(string key);

        //Task<HttpResponse<RemoteConfig>> GetRemoteConfigAsync();

        //Task<HttpResponse<UncertifiedPolicies>> GetUncertifiedPoliciesAsync();

        Task<HttpResponse<User>> GetUserAsync();

        //Task<HttpResponse<TokenResponse>> LoginAsync(string userName, string password, bool storeResults, bool attemptFromStoredCreds = false);

        //Task<bool> IsLoggedIn();

        //Task<bool> IsNewPasswordEqualToCurrentPasswordAsync(string password);

        //Task<HttpResponse<string>> LogoutAsync();

        //Task<HttpResponse<string>> RegisterDeviceAsync(string deviceToken);

        //Task<HttpResponse<string>> ResetPasswordAsync(string mail, string securityResponse, string organization);

        //Task<HttpResponse<string>> RevokeTokenAsync(string token, string tokenTypeHint);

        //Task SetLocalValueForUser(string key, string value);

        //Task<HttpResponse<string>> UpdateUncertifiedPoliciesAsync(UncertifiedPolicies uncertifiedPolicies);

        //Task<HttpResponse<string>> UpdateUserAsync(UserUpdate update);

        //Task<HttpResponse<string>> VerifySecurityAnswerAsync(string answer);

    }
}
