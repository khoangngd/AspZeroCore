using System.Collections.Generic;
using tls.demo.Auditing.Dto;
using tls.demo.Dto;

namespace tls.demo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
