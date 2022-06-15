using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Users
{
    public class UserLoginAttemptsViewModel
    {
        public List<ComboboxItemDto> LoginAttemptResults { get; set; }
    }
}