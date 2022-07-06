using ForOleksiyAspNet5.Data;
using ForOleksiyAspNet5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOleksiyAspNet5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovesController : ControllerBase
    {
        private MyDbContext _context;

        public MovesController(MyDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Moves> Get([FromQuery] DateTime created_start, [FromQuery] DateTime created_end)
        {

            var model = _context.Moveses.Where(x => x.Created >= created_start &&
             x.Created <= created_end).ToArray();

            return model;
        }

   
    }
}
