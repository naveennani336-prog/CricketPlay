using CricketPlay.Now.API.Models;

namespace CricketPlay.Now.API.Managers
{
    public interface IAccountManager
    {
        Task<RegistrationResult> RegisterUserAsync(UserRegistration userRegistration);
        Task<AuthResponse> AuthenticateUserAsync(UserAuthentication userAuthentication);
        Task<ApplicationUser> GenarateUserClaimsAsync(AuthResponse authResponse);
        Task<long> ForgotPasswordAsync(ForgotPassword userServices);
        Task<bool> ResetPasswordAsync(ResetPassword resetPassword);
        Task<bool> ChangePasswordAsync(ChangePassword changePassword);
        Task<AuthResponse> LoginOrRegisterExternalUserAsync(ExternalUserInfo externalUserInfo);
    }
}
