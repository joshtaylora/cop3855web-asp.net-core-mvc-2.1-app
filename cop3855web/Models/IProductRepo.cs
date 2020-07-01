using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cop3855web.Models
{
    public interface IProductRepo
    {
        IEnumerable<Product> Products { get; }
    }
}
