using System.Collections.Generic;
using tls.demo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace tls.demo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
