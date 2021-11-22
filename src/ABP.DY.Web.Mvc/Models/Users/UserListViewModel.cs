using System.Collections.Generic;
using ABP.DY.Roles.Dto;

namespace ABP.DY.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
