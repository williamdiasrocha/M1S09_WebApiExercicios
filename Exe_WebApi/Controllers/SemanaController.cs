using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exe_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Exe_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemanaController : Controller    
    {
        private readonly SemanaContext _semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            _semanaContext = semanaContext;
        }


        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }


        [HttpPost]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel.Id > 0)
            {
                return Ok();
            }

            return BadRequest("Id deve ser maior que 0");
        }

    }
}