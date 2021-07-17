using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteServices clientServices)
        {
            clientServices.AdcionarCliente(new Cliente());
        }
    }
}
