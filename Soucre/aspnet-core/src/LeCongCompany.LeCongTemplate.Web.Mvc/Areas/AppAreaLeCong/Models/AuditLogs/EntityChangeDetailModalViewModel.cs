using System;
using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Auditing.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.AuditLogs
{
    public class EntityChangeDetailModalViewModel
    {
        public string EntityTypeFullName { get; set; }

        public DateTime ChangeTime { get; set; }

        public string UserName { get; set; }

        public List<EntityPropertyChangeDto> EntityPropertyChanges { get; set; }

        public EntityChangeDetailModalViewModel(List<EntityPropertyChangeDto> output, EntityChangeListDto entityChangeListDto)
        {
            EntityPropertyChanges = output;
            EntityTypeFullName = entityChangeListDto.EntityTypeFullName;
            ChangeTime = entityChangeListDto.ChangeTime;
            UserName = entityChangeListDto.UserName;
        }
    }
}