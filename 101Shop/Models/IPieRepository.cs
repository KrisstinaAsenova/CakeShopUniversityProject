using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }

        Pie GetPieById(int pieId);

        Pie Create(string name, string shortDesc, string longDesc, decimal price);

        ICollection<Pie> GetAllPies();
    }
}
