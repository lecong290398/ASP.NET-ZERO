﻿using Abp.AspNetCore.Mvc.Authorization;
using LeCongCompany.LeCongTemplate.Authorization;
using LeCongCompany.LeCongTemplate.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace LeCongCompany.LeCongTemplate.Web.Controllers
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