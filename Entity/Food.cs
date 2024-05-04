namespace FastFoodDeliveryVFE.Entity
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Commande Commande { get; set; } // Relation: Chaque Food est associé à une Commande
    }
}
