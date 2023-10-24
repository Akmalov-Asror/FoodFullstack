using Food.Entities.EntityInterface;

namespace Food.Entities;    

public class Food : IEntity
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }
}