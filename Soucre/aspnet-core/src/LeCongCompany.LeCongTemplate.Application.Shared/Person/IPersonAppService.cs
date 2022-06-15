using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Person.Dto;
using LeCongCompany.LeCongTemplate.Phone;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Person
{
    public interface IPersonAppService : IApplicationService
    {
        Task<ListResultDto<PersonListDto>> GetPeople(GetPeopleInput input);

        Task<int> CreatePerson(CreatePersonInput input);

        Task  DeletePerson(EntityDto input);

        Task DeletePhone(EntityDto<long> input);
        Task<PhoneInPersonListDto> AddPhone(AddPhoneInput input);
        Task<EditPersonInput> GetPersonForEdit(IEntityDto input);
        Task EditPerson(EditPersonInput input);
    }
}
