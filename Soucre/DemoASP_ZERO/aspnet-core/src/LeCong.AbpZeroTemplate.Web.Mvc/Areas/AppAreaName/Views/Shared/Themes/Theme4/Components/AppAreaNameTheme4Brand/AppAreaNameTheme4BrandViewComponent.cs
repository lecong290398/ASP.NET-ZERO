﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;
using LeCong.AbpZeroTemplate.Web.Session;
using LeCong.AbpZeroTemplate.Web.Views;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Themes.Theme4.Components.AppAreaNameTheme4Brand
{
    public class AppAreaNameTheme4BrandViewComponent : AbpZeroTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme4BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}