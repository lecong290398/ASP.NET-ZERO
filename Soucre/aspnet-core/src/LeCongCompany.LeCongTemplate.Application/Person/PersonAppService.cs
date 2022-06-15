using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using AutoMapper;
using LeCongCompany.LeCongTemplate.Authorization;
using LeCongCompany.LeCongTemplate.Person.Dto;
using LeCongCompany.LeCongTemplate.Phone;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Person
{
    [AbpAuthorize(AppPermissions.Pages_PhoneBook)]
    public class PersonAppService : LeCongTemplateAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        private readonly IRepository<Phone.Phone, long> _phoneRepository;

        public PersonAppService(IRepository<Person> personRepository, IRepository<Phone.Phone, long> phoneRepository)
        {
            _personRepository = personRepository;
            _phoneRepository = phoneRepository;
        }

        public async Task<ListResultDto<PersonListDto>> GetPeople(GetPeopleInput input)
        {
            var persons =  _personRepository
                .GetAll()
                .Include(p => p.Phones)
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.Name.Contains(input.Filter) ||
                            p.Surname.Contains(input.Filter) ||
                            (!string.IsNullOrEmpty(p.EmailAddress) && p.EmailAddress.Contains(input.Filter))
                )
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Surname)
                .ToList();

            return new ListResultDto<PersonListDto>(ObjectMapper.Map<List<PersonListDto>>(persons));
        }


        [AbpAuthorize(AppPermissions.Pages_PhoneBook_CreatePerson)]
        public async Task<int> CreatePerson(CreatePersonInput input)
        {
            var result = await _personRepository.InsertAsync(new Person { Name = input.Name, Surname = input.Surname, CreationTime = DateTime.Now, IsDeleted = false, EmailAddress = input.EmailAddress });
            return result.Id;
        }


        [AbpAuthorize(AppPermissions.Pages_PhoneBook_DeletePerson)]
        public async Task DeletePerson(EntityDto input)
        {
              await _personRepository.DeleteAsync(input.Id);
        }



        public async Task DeletePhone(EntityDto<long> input)
        {
            await _phoneRepository.DeleteAsync(input.Id);
        }

        public async Task<PhoneInPersonListDto> AddPhone(AddPhoneInput input)
        {
            try
            {
                var person = _personRepository.Get(input.PersonId);
                await _personRepository.EnsureCollectionLoadedAsync(person, p => p.Phones);

                var phone = ObjectMapper.Map<Phone.Phone>(input);
                person.Phones.Add(phone);

                await CurrentUnitOfWork.SaveChangesAsync();

                return ObjectMapper.Map<PhoneInPersonListDto>(phone);
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }


        public async Task<EditPersonInput> GetPersonForEdit(IEntityDto input)
        {
            var person = await _personRepository.GetAsync(input.Id);
            return ObjectMapper.Map<EditPersonInput>(person);
        }

        public async Task EditPerson(EditPersonInput input)
        {
            var person = await _personRepository.GetAsync(input.Id);
            person.Name = input.Name;
            person.Surname = input.Surname;
            person.EmailAddress = input.EmailAddress;
            await _personRepository.UpdateAsync(person);
        }


    }
}
