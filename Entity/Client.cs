namespace FastFoodDeliveryVFE.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DeliveryPerson DeliveryPerson { get; set; }
        public List<Commande> Commandes { get; set; }
    }

}
