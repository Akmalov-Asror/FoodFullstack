using Food.Data;
using Food.Entities;
using Food.Services.Generics;

namespace Food.Repositories;

public class CategoryRepository : GenericRepository<Category, AppDbContext>
{
    public CategoryRepository(AppDbContext context) : base(context) { }
}