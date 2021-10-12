using System.Collections.Generic;
using tls.demo.Authorization.Delegation;
using tls.demo.Authorization.Users.Delegation.Dto;

namespace tls.demo.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
