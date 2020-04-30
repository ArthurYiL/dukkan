using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Roles;
using Dukkan.Authorization.Roles;

namespace Dukkan.Roles.Dto
{
    public class CreateRoleDto
    {
        [Required]
        [StringLength(AbpRoleBase.MaxNameLength)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(AbpRoleBase.MaxDisplayNameLength)]
        public string DisplayName { get; set; }

        public string NormalizedName { get; set; }
        
        [StringLength(RoleConsts.DescriptionMaxLength)]
        public string Description { get; set; }

        public List<string> GrantedPermissions { get; set; }
    }
}