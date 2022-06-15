
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Organizations;
using LeCongCompany.LeCongTemplate.Person.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Person
{
    [AutoMapFrom(typeof(ListResultDto<PersonListDto>))]
    public class IndexViewModel : ListResultDto<PersonListDto>
    {
        public string Filter { get; set; }
    }
}
