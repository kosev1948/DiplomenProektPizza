namespace PicaButik.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }
    }
}
