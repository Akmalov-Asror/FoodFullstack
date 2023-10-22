using Food.Entities;
using Food.Entities.EntityInterface;
using Food.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Food.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : MoldController<Category, CategoryRepository>
{
    public CategoryController(CategoryRepository repository) : base(repository) { }

}