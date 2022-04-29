using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Users.Importing.Dto;
using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
