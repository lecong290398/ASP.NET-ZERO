using System.Threading.Tasks;
using Abp.Domain.Uow;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using LeCong.AbpZeroTemplate.Authorization.Delegation;
using LeCong.AbpZeroTemplate.Authorization.Users.Delegation;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;
using LeCong.AbpZeroTemplate.Web.Views;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Components.
    AppAreaNameActiveUserDelegationsCombobox
{
    public class AppAreaNameActiveUserDelegationsComboboxViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public AppAreaNameActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService,
            IUserDelegationConfiguration userDelegationConfiguration,
            IUnitOfWorkManager unitOfWorkManager)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            return await _unitOfWorkManager.WithUnitOfWorkAsync(async () =>
            {
                var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
                var model = new ActiveUserDelegationsComboboxViewModel
                {
                    UserDelegations = activeUserDelegations,
                    UserDelegationConfiguration = _userDelegationConfiguration
                };

                return View(model);
            });
        }
    }
}
