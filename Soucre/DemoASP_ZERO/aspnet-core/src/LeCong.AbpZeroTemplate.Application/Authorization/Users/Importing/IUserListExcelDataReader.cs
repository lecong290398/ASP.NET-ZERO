using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace LeCong.AbpZeroTemplate.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
