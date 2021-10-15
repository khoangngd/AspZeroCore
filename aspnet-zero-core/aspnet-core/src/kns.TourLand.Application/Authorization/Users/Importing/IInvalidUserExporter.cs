using System.Collections.Generic;
using kns.TourLand.Authorization.Users.Importing.Dto;
using kns.TourLand.Dto;

namespace kns.TourLand.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
