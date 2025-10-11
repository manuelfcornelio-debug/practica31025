using Microsoft.EntityFrameworkCore;

namespace practica31025.Model
{
    public class FoodContext:DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) 
        { 
        
        }

        public DbSet<Food> Foods { get; set; }
    }
}
