using Abp.Application.Services.Dto;

namespace kns.TourLand.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}