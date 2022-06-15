using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Person.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.PhoneBook
{

    [AutoMapFrom(typeof(GetPersonForEditOutput))]
    public class EditPersonModalViewModel : GetPersonForEditOutput
    {

    }
}
