namespace PicaButik.Data
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizzas { get; set; }
        public double Quantity { get; set; }

        public DateTime SelectionDate { get; set; } 
    }
}
