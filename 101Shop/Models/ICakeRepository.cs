using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> cakes { get; }

        Cake GetcakeById(int cakeId);

        Cake Create(string name, string shortDesc, string longDesc, decimal price);

        ICollection<Cake> GetAllCakes();
    }
}
