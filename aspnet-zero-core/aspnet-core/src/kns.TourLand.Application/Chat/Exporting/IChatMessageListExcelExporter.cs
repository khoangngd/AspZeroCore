using System.Collections.Generic;
using Abp;
using kns.TourLand.Chat.Dto;
using kns.TourLand.Dto;

namespace kns.TourLand.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
