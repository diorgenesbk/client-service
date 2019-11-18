using System.Collections.Generic;
using Client.DataObject.Response;
using Client.Infrastructure.Context;
using Client.Service.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Client.Service.Proxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController(ClientContext context)
        {
            this.PersonService = new PersonService(context);
        }

        protected PersonService PersonService { get; set; }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "up";
        }

        [HttpGet("data/{cpf}")]
        public ActionResult<ClientDataDto> GetClientData(string cpf)
        {
            //TODO: 
            // - implementar testes
            return this.PersonService.GetClientData(cpf);
        }
    }
}
