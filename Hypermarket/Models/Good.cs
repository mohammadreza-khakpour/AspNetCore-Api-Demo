using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hypermarket.Models
{
    public class Good
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Code { get; set; }
        public int Count { get; set; } = 0;
        public int Price { get; set; } = 0;

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public GoodCategory Category { get; set; }
    }
}
