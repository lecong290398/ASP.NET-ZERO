using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Phone;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LeCongCompany.LeCongTemplate.Person.Dto
{
    public class PersonListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }


        public Collection<PhoneInPersonListDto> Phones { get; set; }
    }

    public class PhoneInPersonListDto : CreationAuditedEntityDto<long>
    {
        public PhoneType Type { get; set; }

        public string Number { get; set; }
    }
}
