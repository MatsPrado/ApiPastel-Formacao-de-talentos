using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastelDomain.core.Models
{
    public abstract class Entity 
    {
        public int Id { get; protected set; }
    }
}
