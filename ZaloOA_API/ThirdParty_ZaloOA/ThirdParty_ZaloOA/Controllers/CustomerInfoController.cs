using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdParty_ZaloOA.Controllers
{
    [Route("api/CustomerInfo")]
    [ApiController]
    public class CustomerInfoController : ControllerBase
    {
        [HttpGet]
        public void GetCustomer()
        {
            Response.StatusCode = 200;
        } 
    }
}
