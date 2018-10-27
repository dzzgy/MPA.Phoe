using System.Collections.Generic;
using MPA.Phone.Roles.Dto;
using MPA.Phone.Users.Dto;

namespace MPA.Phone.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
