using System.Collections.Generic;
using Abp;
using tls.demo.Chat.Dto;
using tls.demo.Dto;

namespace tls.demo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
