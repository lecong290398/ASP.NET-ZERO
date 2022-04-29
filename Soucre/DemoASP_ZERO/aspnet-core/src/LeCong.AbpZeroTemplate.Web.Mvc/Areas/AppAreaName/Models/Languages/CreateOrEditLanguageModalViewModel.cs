using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.Localization.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}