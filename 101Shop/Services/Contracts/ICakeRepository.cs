using _101Shop.Models;
using _101Shop.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _101Shop.Services.Contracts
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> cakes { get; }

        Task<Cake> GetcakeById(int cakeId);

        Task<Cake> Create(string name, string shortDesc, string longDesc, decimal price, string allergyInformation, string imageURL, bool isSpecial);

        Task<Comment> AddComment(Comment comment);

        Task RemoveCake(int cakeId);

        Task EditCake(CakeViewModel cake);

        Task<ICollection<Cake>> GetAllCakes();

        Task<ICollection<Cake>> GetAllSpecialCakes();
    }
}
