using System.Collections.Generic;
using ABP.DY.Roles.Dto;

namespace ABP.DY.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}