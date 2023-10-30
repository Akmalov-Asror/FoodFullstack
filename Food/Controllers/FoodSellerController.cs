using System.Security.Claims;
using Food.Dto_s;
using Food.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class FoodSellerController : ControllerBase
{
    private readonly ISellerFoodRepository _foodRepository;
    public FoodSellerController(ISellerFoodRepository foodRepository) => _foodRepository = foodRepository;

    [HttpPost]
    public async Task<IActionResult> BuyNewProducts(int foodId, SellerFood sellerFood) => Ok(await _foodRepository.SellerFood(foodId, sellerFood));

    [HttpGet]
    public async Task<IActionResult> GetByCount() => Ok(await _foodRepository.GetTopSellerFoodsByPrice());

    [HttpGet("User")]
    public async Task<IActionResult> GetUser()
    {
        return Ok(await _foodRepository.GetNameFromClaims(User));
    }
}