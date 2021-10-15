using System.Collections.Generic;
using kns.TourLand.Authorization.Users.Dto;
using kns.TourLand.Dto;

namespace kns.TourLand.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}