using System.Collections.Generic;
using kns.TourLand.Auditing.Dto;
using kns.TourLand.Dto;

namespace kns.TourLand.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
