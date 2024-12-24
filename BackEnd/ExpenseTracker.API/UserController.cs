using ExpenseTracker.Application.UseCases;
using ExpenseTracker.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly GetUserByIdUseCase _getUserByIdUseCase;

        public UsersController(GetUserByIdUseCase getUserByIdUseCase)
        {
            _getUserByIdUseCase = getUserByIdUseCase;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _getUserByIdUseCase.ExecuteAsync(id);
            return Ok(user);
        }
    }
}
