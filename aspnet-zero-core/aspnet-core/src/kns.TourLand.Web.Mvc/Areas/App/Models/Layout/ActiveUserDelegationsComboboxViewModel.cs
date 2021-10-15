using System.Collections.Generic;
using kns.TourLand.Authorization.Delegation;
using kns.TourLand.Authorization.Users.Delegation.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
