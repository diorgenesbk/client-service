using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Domain.Entities
{
    public class Debt : BaseEntity
    {
        public int DebtId { get; }

        public int PersonId { get; set; }

        public decimal Value { get; set; }

        public string Description { get; set; }
    }
}
