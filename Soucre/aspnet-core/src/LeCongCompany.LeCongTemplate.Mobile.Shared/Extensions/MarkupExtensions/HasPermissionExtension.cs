using System;
using LeCongCompany.LeCongTemplate.Core;
using LeCongCompany.LeCongTemplate.Core.Dependency;
using LeCongCompany.LeCongTemplate.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeCongCompany.LeCongTemplate.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}