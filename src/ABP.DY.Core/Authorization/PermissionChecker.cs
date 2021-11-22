using Abp.Authorization;
using ABP.DY.Authorization.Roles;
using ABP.DY.Authorization.Users;

namespace ABP.DY.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
