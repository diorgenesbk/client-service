using Client.DataObject.Response;
using Client.Domain.Entities;
using Client.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace Client.Service.Business
{
    public class DebtService : BaseService<Debt>
    {
       public DebtService(ClientContext context) : base(context)
       {          
       }

        public IList<Debt> GetDebtsFromPerson(int personId)
        {
            return this.Repository.Context.Query<Debt>()
                .Where(d => d.PersonId == personId)
                .ToList();
        }
    }
}
