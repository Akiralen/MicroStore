using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityAPI.Models
{
    public class UserPermissions
    {
        bool canCreateUser { get; set; }
        bool canEditCatalog { get; set; }
    }
}