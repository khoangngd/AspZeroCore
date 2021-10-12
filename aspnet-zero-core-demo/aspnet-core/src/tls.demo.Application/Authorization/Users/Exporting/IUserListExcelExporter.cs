using System.Collections.Generic;
using tls.demo.Authorization.Users.Dto;
using tls.demo.Dto;

namespace tls.demo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}