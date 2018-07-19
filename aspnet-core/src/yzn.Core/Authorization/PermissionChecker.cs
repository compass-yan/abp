using Abp.Authorization;
using yzn.Authorization.Roles;
using yzn.Authorization.Users;

namespace yzn.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
