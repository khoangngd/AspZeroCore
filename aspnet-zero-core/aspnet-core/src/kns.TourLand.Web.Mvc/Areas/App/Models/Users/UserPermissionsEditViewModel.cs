using Abp.AutoMapper;
using kns.TourLand.Authorization.Users;
using kns.TourLand.Authorization.Users.Dto;
using kns.TourLand.Web.Areas.App.Models.Common;

namespace kns.TourLand.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}