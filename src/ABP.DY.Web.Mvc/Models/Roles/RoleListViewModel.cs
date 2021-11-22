using System.Collections.Generic;
using ABP.DY.Roles.Dto;

namespace ABP.DY.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
