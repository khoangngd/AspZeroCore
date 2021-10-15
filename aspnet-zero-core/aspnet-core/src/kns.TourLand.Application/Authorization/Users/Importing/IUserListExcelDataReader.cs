using System.Collections.Generic;
using kns.TourLand.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace kns.TourLand.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
