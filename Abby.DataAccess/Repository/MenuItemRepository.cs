using Abby.DataAccess.Data;
using Abby.DataAccess.Repository.IRepository;
using Abby.Models;

namespace Abby.DataAccess.Repository;

public class MenuItemRepository :Repository<MenuItem>, IMenuItemRepository
{
    private readonly ApplicationDbContext _db;
    public MenuItemRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    
    public void Save()
    {
        _db.SaveChanges();
    }
    
    public void Update(MenuItem obj)
    {
        var objFromDb = _db.MenuItem.FirstOrDefault(u => u.Id == obj.Id);
        objFromDb.Name = obj.Name;
        objFromDb.Description = obj.Description;
        objFromDb.Price = obj.Price;
        objFromDb.CategoryId = obj.CategoryId;
        objFromDb.FoodTypeId = obj.FoodTypeId;
        if (objFromDb.Image != null)
        {
            objFromDb.Image = obj.Image;
        }

    }


  
}