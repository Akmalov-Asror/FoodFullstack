using Food.Dto_s;
using Food.Entities;

namespace Food.Interface;

public interface IFoodRepository
{
    Task<Entities.Food> GetById(int id);
    Task<List<Entities.Food>> GetListAsync();
    Task<FoodDto> CreateUser(FoodDto food);
    Task<FoodDto> UpdateUser(int id, FoodDto food);
    Task DeleteUser(int id);
} 