using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.Data
{
    public class tblUserRole
    {
        [Key]
        public int RoleId { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }

    }
}
