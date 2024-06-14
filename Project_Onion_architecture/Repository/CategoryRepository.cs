using Project_Onion_architecture.Data;
using Project_Onion_architecture.Models;

namespace Project_Onion_architecture.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
