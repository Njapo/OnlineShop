using OnlineShop_api.Models;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace OnlineShop_api.Repository.IRepository
{
    public interface IItemRepository : IRepository<Item>
    {
        Task<Item> Update(Item entity);
    }
}
