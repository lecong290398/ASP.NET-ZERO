﻿using System.Threading.Tasks;
using Abp.Dependency;

namespace LeCong.AbpZeroTemplate.UiCustomization
{
    public interface IUiThemeCustomizerFactory : ISingletonDependency
    {
        Task<IUiCustomizer> GetCurrentUiCustomizer();

        IUiCustomizer GetUiCustomizer(string theme);
    }
}