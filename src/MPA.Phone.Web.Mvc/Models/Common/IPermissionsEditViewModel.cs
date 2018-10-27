using System.Collections.Generic;
using MPA.Phone.Roles.Dto;

namespace MPA.Phone.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}