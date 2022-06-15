using Abp.Localization;
using LeCongCompany.LeCongTemplate.Person.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Person
{
    public class PhoneRowInPersonListViewModel
    {
        public PhoneInPersonListDto Phone { get; set; }

        public PhoneRowInPersonListViewModel(PhoneInPersonListDto phone)
        {
            Phone = phone;
        }

        public string GetPhoneTypeAsString()
        {

            var sadassd = "PhoneType_" + Phone.Type;
            return LocalizationHelper.GetString(LeCongTemplateConsts.LocalizationSourceName, "PhoneType_" + Phone.Type);


        }
    }
}
