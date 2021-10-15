using Abp.AutoMapper;
using kns.TourLand.Organizations.Dto;

namespace kns.TourLand.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}