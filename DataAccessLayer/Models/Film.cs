using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Film
    {
        //test
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
