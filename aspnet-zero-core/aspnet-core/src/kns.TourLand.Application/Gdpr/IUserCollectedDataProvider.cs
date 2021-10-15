using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using kns.TourLand.Dto;

namespace kns.TourLand.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
