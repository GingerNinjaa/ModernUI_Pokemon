﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.Data
{
   public  class tblUser
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Position { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Role { get; set; }   
    }
}
