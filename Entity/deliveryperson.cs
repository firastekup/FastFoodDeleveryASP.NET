namespace FastFoodDeliveryVFE.Entity
{
    public class DeliveryPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Client> Clients { get; set; }
        public List<Commande> Commandes { get; set; }
        public Admin Admin { get; set; }
    }
}
