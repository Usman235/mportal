using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Order:IEntityBase
    {
        public int Id { get; set; }
        public string Demo { get; set; }

    }
}
