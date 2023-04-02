using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exe_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

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

    }
}