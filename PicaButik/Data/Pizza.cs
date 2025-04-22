namespace PicaButik.Data
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double WeightGrams { get; set; }
        public bool IsDietary { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public string Ingredients { get; set; }
        public string ImageURL { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
