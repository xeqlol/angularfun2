using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities
{
    class Role : IEntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
