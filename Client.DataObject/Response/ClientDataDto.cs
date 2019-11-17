using System;
using System.Collections.Generic;
using System.Text;

namespace Client.DataObject.Response
{
    public class ClientDataDto
    {
        public PersonDto Person { get; set; }

        public AdressDto Adress { get; set; }

        public IList<DebtDto> DebtList { get; set; }


    }
}
