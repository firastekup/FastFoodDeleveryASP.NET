namespace FastFoodDeliveryVFE.Entity
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
        public List<Commande> CommandesGerees { get; set; }
        public List<DeliveryPerson> Livreurs { get; set; }
    }
}
