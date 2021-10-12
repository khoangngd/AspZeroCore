using System.Collections.Generic;
using tls.demo.Authorization.Users.Importing.Dto;
using tls.demo.Dto;

namespace tls.demo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
