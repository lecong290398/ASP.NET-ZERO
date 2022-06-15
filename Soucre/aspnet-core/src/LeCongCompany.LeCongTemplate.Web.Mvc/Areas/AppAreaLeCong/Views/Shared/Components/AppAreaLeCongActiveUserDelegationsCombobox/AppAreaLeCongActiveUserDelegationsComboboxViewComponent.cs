using System.Threading.Tasks;
using Abp.Domain.Uow;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Authorization.Delegation;
using LeCongCompany.LeCongTemplate.Authorization.Users.Delegation;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout;
using LeCongCompany.LeCongTemplate.Web.Views;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Views.Shared.Components.
    AppAreaLeCongActiveUserDelegationsCombobox
{
    public class AppAreaLeCongActiveUserDelegationsComboboxViewComponent : LeCongTemplateViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public AppAreaLeCongActiveUserDelegationsComboboxViewComponent(
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
