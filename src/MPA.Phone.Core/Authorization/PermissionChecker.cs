using Abp.Authorization;
using MPA.Phone.Authorization.Roles;
using MPA.Phone.Authorization.Users;

namespace MPA.Phone.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
