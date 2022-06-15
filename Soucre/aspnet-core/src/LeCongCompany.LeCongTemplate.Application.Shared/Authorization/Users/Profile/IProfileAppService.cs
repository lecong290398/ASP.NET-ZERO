using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using LeCongCompany.LeCongTemplate.Authorization.Users.Dto;
using LeCongCompany.LeCongTemplate.Authorization.Users.Profile.Dto;
using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Profile
{
    public interface IProfileAppService : IApplicationService
    {
        Task<CurrentUserProfileEditDto> GetCurrentUserProfileForEdit();

        Task UpdateCurrentUserProfile(CurrentUserProfileEditDto input);

        Task ChangePassword(ChangePasswordInput input);

        Task UpdateProfilePicture(UpdateProfilePictureInput input);

        Task<GetPasswordComplexitySettingOutput> GetPasswordComplexitySetting();

        Task<GetProfilePictureOutput> GetProfilePicture();

        Task<GetProfilePictureOutput> GetProfilePictureByUser(long userId);
        
        Task<GetProfilePictureOutput> GetProfilePictureByUserName(string username);

        Task<GetProfilePictureOutput> GetFriendProfilePicture(GetFriendProfilePictureInput input);

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<UpdateGoogleAuthenticatorKeyOutput> UpdateGoogleAuthenticatorKey();

        Task SendVerificationSms(SendVerificationSmsInputDto input);

        Task VerifySmsCode(VerifySmsCodeInputDto input);

        Task PrepareCollectedData();
    }
}
