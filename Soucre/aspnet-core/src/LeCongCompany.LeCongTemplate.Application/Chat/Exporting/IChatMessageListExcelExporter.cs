using System.Collections.Generic;
using Abp;
using LeCongCompany.LeCongTemplate.Chat.Dto;
using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
