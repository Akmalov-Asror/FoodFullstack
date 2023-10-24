using Food.Data;
using Food.Services.Generics;
using Foods = Food.Entities.Food;

namespace Food.Repositories;

public class FoodRepository : GenericRepository<Foods, AppDbContext>
{
    public FoodRepository(AppDbContext context) : base(context) { }
}