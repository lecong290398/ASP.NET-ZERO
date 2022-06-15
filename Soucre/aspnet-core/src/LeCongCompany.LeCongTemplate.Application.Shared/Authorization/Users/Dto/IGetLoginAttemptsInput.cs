using Abp.Application.Services.Dto;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}