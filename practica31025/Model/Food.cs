using System.ComponentModel.DataAnnotations;

namespace practica31025.Model
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public TypeFood Description { get; set; }
        public int Kcal { get; set; }
    }

    public enum TypeFood
    {
        Undefined,
        Vegetables,
        Fruits 
    }
}
