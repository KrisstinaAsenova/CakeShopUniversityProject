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

        Cake Create(string name, string shortDesc, string longDesc, decimal price, string allergyInformation, string imageURL, bool isSpecial);

        void RemoveCake(int cakeId);

        void EditCake(Cake cake);

        ICollection<Cake> GetAllCakes();

        ICollection<Cake> GetAllSpecialCakes();
    }
}
