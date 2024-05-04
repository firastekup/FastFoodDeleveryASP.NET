namespace FastFoodDeliveryVFE.Entity
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Prix { get; set; }
        public TimeSpan TempsDeLivraison { get; set; }
        public Client Client { get; set; }
        public Admin Admin { get; set; }
        public DeliveryPerson DeliveryPerson { get; set; }
        public List<Food> Foods { get; set; } // Relation: Chaque Commande contient une liste de Foods
    }
}
