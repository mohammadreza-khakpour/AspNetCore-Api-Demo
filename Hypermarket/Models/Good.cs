using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypermarket.Models
{
    public class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public GoodCategory Category { get; set; }
    }
}
