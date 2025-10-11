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


        //public List<Food> All() 
        //{
        //    return _foodList;
        //}

        //public Food Add(Food food)
        //{
        //    _foodList.Add(food);
        //    return food;
        //}

        //public Food? Delete(Food food)
        //{
        //    var foodToDelete = _foodList.FirstOrDefault(f => f.Id == food.Id);
        //    if (foodToDelete != null)
        //    {
        //        _foodList.Remove(foodToDelete);
        //        return foodToDelete;
        //    }

        //    return null;
        //}
    }



}
