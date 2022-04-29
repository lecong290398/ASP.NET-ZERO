using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Users.Dto;
using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}