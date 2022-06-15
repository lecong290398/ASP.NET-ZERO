using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Authorization.Users.Importing.Dto;
using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
