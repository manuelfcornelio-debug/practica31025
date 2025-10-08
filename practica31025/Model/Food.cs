namespace practica31025.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public TypeFood Description { get; set; }


    }

    public enum TypeFood
    {
        Vegetables = 69,
        Fruits = 13

    }
}
