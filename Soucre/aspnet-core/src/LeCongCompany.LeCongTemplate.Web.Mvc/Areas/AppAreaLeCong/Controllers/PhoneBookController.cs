using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Authorization;
using LeCongCompany.LeCongTemplate.Person;
using LeCongCompany.LeCongTemplate.Person.Dto;
using LeCongCompany.LeCongTemplate.Phone;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Person;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.PhoneBook;
using LeCongCompany.LeCongTemplate.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Controllers
{
    [Area("AppAreaLeCong")]
    [AbpMvcAuthorize(AppPermissions.Pages_PhoneBook)]
    public class PhoneBookController : LeCongTemplateControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PhoneBookController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;

        }

        public async Task<ActionResult> Index(GetPeopleInput input)
        {
            var output = await _personAppService.GetPeople(input);
            var model = ObjectMapper.Map<IndexViewModel>(output);
            model.Filter = input.Filter;
            return View(model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_PhoneBook_CreatePerson)]
        public PartialViewResult CreatePersonModal()
        {
            return PartialView("_CreatePersonModal");
        }

        [HttpPost]
        public async Task<PartialViewResult> AddPhone([FromBody] AddPhoneInput input)
        {
            PhoneInPersonListDto phoneInPersonList = await _personAppService.AddPhone(input);
            var model = new PhoneRowInPersonListViewModel(phoneInPersonList);

            return PartialView("_PhoneRowInPersonList", model);
        }

        public async Task<PartialViewResult> EditPersonModal(int id)
        {
            try
            {
                var output = await _personAppService.GetPersonForEdit(new EntityDto { Id = id });
                var viewModel = new EditPersonModalViewModel
                {
                    EmailAddress = output.EmailAddress,
                    Id = output.Id,
                    Name = output.Name,
                    Surname = output.Surname
                };
                return PartialView("_EditPersonModal", viewModel);
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
