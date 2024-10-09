using Microsoft.EntityFrameworkCore;
using OnlineShop_api.Data;
using OnlineShop_api.Models;
using OnlineShop_api.Repository.IRepository;
using System.Linq.Expressions;

namespace OnlineShop_api.Repository
{
    public class ItemRepository :Repository<Item>, IItemRepository
    {
        private readonly ApplicationDbContext _db;
        public ItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Item> Update(Item entity)
        {
            entity.UpdatedDate=DateTime.Now;
            _db.Items.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
