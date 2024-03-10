using Abp.Authorization;
using eManager.Authorization.Roles;
using eManager.Authorization.Users;

namespace eManager.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
