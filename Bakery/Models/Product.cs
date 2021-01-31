using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProducedDay { get; set; }
        public string Ingridients { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int Number { get; set; }

    }
}
