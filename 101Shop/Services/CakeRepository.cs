using _101Shop.Data;
using _101Shop.Models;
using _101Shop.Services.Contracts;
using _101Shop.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _101Shop.Services
{
    public class CakeRepository : ICakeRepository
    {
        private readonly AppDbContext _appDbContext;
        public CakeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cake> cakes
        {
            get
            {
                return _appDbContext.Cakes;
            }
        }

        public async Task<Cake> Create(string name, string shortDesc, string longDesc, decimal price, string allergyInformation, string imageURL, bool isSpecial)
        {
            var cake = new Cake()
            {
                Name = name,
                ShortDescription = shortDesc,
                LongDescription = longDesc,
                Price = price,
                AllergyInformation = allergyInformation,
                ImageUrl = imageURL,
                IsSpecial = isSpecial,
                Comments = new List<Comment>()
            };
            await Task.Run(() => _appDbContext.Cakes.Add(cake));
            await Task.Run(() => _appDbContext.SaveChanges());

            return cake;
        }

        public async Task<Cake> GetcakeById(int cakeId)
        {
            var cake = await Task.Run(() => _appDbContext.Cakes.FirstOrDefault(cake => cake.CakeId == cakeId));
            var comments = await Task.Run(() => _appDbContext.Comments.Where(c => c.CakeId == cakeId).ToList());
            cake.Comments = comments;

            return cake;
        }

        public async Task<ICollection<Cake>> GetAllCakes()
        {
            return await Task.Run(() => _appDbContext.Cakes.Where(x => !x.IsSpecial).ToList());
        }
        public async Task<ICollection<Cake>> GetAllSpecialCakes()
        {
            return await Task.Run(() => _appDbContext.Cakes.Where(x => x.IsSpecial).ToList());
        }

        public async Task RemoveCake(int cakeId)
        {
            var removeCake = await Task.Run(() => _appDbContext.Cakes.FirstOrDefault(x => x.CakeId == cakeId));
            await Task.Run(() => _appDbContext.Cakes.Remove(removeCake));
            await Task.Run(() => _appDbContext.SaveChanges());
        }

        public async Task EditCake(CakeViewModel cake)
        {
            var cakeToEdit = await Task.Run(() => GetcakeById(cake.CakeId));
            cakeToEdit.Name = cake.Name;
            cakeToEdit.ShortDescription = cake.ShortDescription;
            cakeToEdit.LongDescription = cake.LongDescription;
            cakeToEdit.Price = cake.Price;
            cakeToEdit.AllergyInformation = cake.AllergyInformation;
            cakeToEdit.ImageUrl = cake.ImageUrl;
            cakeToEdit.IsSpecial = cake.IsSpecial;

            await Task.Run(() => _appDbContext.SaveChanges());
        }

        public async Task<Comment> AddComment(Comment comment)
        {
            await Task.Run(() => _appDbContext.Comments.Add(comment));
            _appDbContext.SaveChanges();

            return comment;
        }

        public async Task<Comment> GetComments(Comment comment)
        {
            await Task.Run(() => _appDbContext.Comments.Add(comment));
            await Task.Run(() => _appDbContext.SaveChanges());

            return comment;
        }
    }
}
