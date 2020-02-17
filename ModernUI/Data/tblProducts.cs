using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.Data
{
   public class tblProducts
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        [StringLength(150)]
        public string CategoryName { get; set; }
        public string ImageName { get; set; }

    }
}
