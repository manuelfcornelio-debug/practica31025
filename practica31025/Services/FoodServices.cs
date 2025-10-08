using practica31025.Model;

namespace practica31025.Services
{
    public class FoodServices
    {
        private readonly List<Food> _foodList;
        public FoodServices(List<Food> foodList )
        {
           _foodList = foodList; 
        }
        public List<Food> All() 
        {
            


            return _foodList;


        }
        public string saludo()
        {
            return "soy el servicio";
        }
    }



}
