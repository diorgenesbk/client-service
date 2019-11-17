using Client.Domain.Entities;
using Client.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Client.Infrastructure.Context
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> context) : base(context){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(new PersonMap().Configure);
            modelBuilder.Entity<Adress>(new AdressMap().Configure);
            modelBuilder.Entity<Debt>(new DebtMap().Configure);
        }

    }
}
