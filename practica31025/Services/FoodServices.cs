using practica31025.Model;

namespace practica31025.Services
{
    public class FoodServices
    {
        private readonly FoodContext _foodContext;

        public FoodServices(FoodContext foodContext)
        {
            _foodContext = foodContext;
        }


        public List<Food> All()
        {
            return _foodContext.Foods.ToList();
        }

        public Food Add(Food food)
        {
            _foodContext.Foods.Add(food);
            _foodContext.SaveChanges();
            return food;
        }

        public Food? Delete(Food food)
        {
            var foodToDelete = _foodContext.Foods.FirstOrDefault(f => f.Name == food.Name);
            if (foodToDelete != null)
            {
                _foodContext.Foods.Remove(foodToDelete);
                _foodContext.SaveChanges();
                return foodToDelete;
            }

            return null;
        }
    }



}
