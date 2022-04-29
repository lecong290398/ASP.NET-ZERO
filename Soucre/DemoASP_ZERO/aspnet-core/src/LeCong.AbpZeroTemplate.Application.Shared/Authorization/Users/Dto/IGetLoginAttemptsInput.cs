using Abp.Application.Services.Dto;

namespace LeCong.AbpZeroTemplate.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}