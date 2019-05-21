using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public virtual User User { get; set; }
        public virtual Film Film { get; set; }

}
}
