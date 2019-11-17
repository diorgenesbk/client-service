using Client.Domain.Entities;
namespace Client.Domain.Entities
{
    public class Person : BaseEntity
    {
        public int PersonId { get; set; }

        public string Cpf { get; set; }

        public string Name { get; set; }
    }
}
