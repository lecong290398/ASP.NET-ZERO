using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Person;
using LeCongCompany.LeCongTemplate.Person.Dto;
using LeCongCompany.LeCongTemplate.Phone;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Phonebook
{
    public class ProxyPersonAppService : ProxyAppServiceBase, IPersonAppService
    {
        public async Task<int> CreatePerson(CreatePersonInput input)
        {
            return await ApiClient.GetAsync<int>(GetEndpoint(nameof(CreatePerson)), input);
        }

        public async Task DeletePerson(EntityDto input)
        {
            await ApiClient.GetAsync(GetEndpoint(nameof(DeletePerson)), input);
        }

        public async Task<ListResultDto<PersonListDto>> GetPeople(GetPeopleInput input)
        {
            return await ApiClient.GetAsync<ListResultDto<PersonListDto>>(GetEndpoint(nameof(GetPeople)), input);
        }

        public async Task DeletePhone(EntityDto<long> input)
        {
            await ApiClient.GetAsync(GetEndpoint(nameof(DeletePhone)), input);
        }

        public async Task<PhoneInPersonListDto> AddPhone(AddPhoneInput input)
        {
           return await ApiClient.GetAsync<PhoneInPersonListDto>(GetEndpoint(nameof(AddPhone)), input);
        }

        public async Task<EditPersonInput> GetPersonForEdit(IEntityDto input)
        {
            return await ApiClient.GetAsync<EditPersonInput>(GetEndpoint(nameof(GetPersonForEdit)), input);
        }

        public  async Task EditPerson(EditPersonInput input)
        {
            await ApiClient.GetAsync(GetEndpoint(nameof(EditPerson)), input);
        }
    }
}
