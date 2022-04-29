using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Auditing.Dto;
using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
