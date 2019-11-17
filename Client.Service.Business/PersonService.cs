using Client.DataObject.Response;
using Client.Domain.Entities;
using Client.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Service.Business
{
    public class PersonService : BaseService<Person>
    {
       public PersonService(ClientContext context) : base(context)
       {          
       }

        public ClientDataDto GetClientData(string cpf)
        {
            return new ClientDataDto();
        }
    }
}
