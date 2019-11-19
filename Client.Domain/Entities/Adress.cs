namespace Client.Domain.Entities
{
    public class Adress : BaseEntity
    {
        public int AdressId { get; set; }

        public int PersonId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public string PostCode { get; set; }

        public int Number { get; set; }
    }
}
