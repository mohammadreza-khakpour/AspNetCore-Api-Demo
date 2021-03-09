using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hypermarket.Models
{
    public class GoodCategory
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public List<Good> Goods { get; set; }
    }
}
