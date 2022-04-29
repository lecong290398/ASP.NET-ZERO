using System.Collections.Generic;
using Abp;
using LeCong.AbpZeroTemplate.Chat.Dto;
using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
