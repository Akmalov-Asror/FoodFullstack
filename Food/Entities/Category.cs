using Food.Entities.EntityInterface;

namespace Food.Entities;

public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Food> Food { get; set; }
}