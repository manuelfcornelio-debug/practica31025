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

        [HttpGet]
        public IActionResult All()
        {
            

            return Ok(_foodServices.All());

        }
        [HttpGet("Saludo")]
        public IActionResult Details() 
        { 
         return Ok(_foodServices.saludo());
        
        }
        
    }
}
