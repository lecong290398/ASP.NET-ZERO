using Abp.AspNetCore.Mvc.Authorization;
using LeCong.AbpZeroTemplate.Authorization;
using LeCong.AbpZeroTemplate.Storage;
using Abp.BackgroundJobs;

namespace LeCong.AbpZeroTemplate.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}