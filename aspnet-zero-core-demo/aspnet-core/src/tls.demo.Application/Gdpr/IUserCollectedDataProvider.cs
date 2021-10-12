using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using tls.demo.Dto;

namespace tls.demo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
