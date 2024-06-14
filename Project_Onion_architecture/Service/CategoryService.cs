using Project_Onion_architecture.Models;
using Project_Onion_architecture.Repository;

namespace Project_Onion_architecture.Service
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository obj) : base(obj)
        {
        }
    }
}
