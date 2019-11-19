using Client.DataObject.Response;
using Client.Domain.Entities;
using Client.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Service.Business
{
    public class AdressService : BaseService<Person>
    {
       public AdressService(ClientContext context) : base(context)
       {          
       }

        public ClientDataDto GetClientData(string cpf)
        {
            return new ClientDataDto();
        }
    }
}
