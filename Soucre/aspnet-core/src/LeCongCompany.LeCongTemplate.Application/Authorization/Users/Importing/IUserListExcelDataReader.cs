using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
