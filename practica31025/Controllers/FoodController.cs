using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practica31025.Model;
using practica31025.Services;

namespace practica31025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly FoodServices _foodServices;
        public FoodController(FoodServices foodServices)
        {
            _foodServices = foodServices;
        }

        [HttpGet("All")]
        public IActionResult All()
        {
            return Ok(_foodServices.All());
        }

        [HttpPost("Add")]
        public IActionResult Create([FromBody] Food food)
        {
            return Created("api/Food/add", _foodServices.Add(food));
        }

        [HttpDelete("DeleteByName")]
        public IActionResult Delete([FromBody] Food food)
        {
            return Ok(_foodServices.Delete(food));
        }


    }
}
