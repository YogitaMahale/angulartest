 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatingAPP.API.Data;
using DatingAPP.API.Models;
namespace DatingAPP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class testControllers: ControllerBase
    {
        private readonly DataContext _context;
        public testControllers(DataContext context)
        {
            _context=context ?? throw new ArgumentNullException(nameof(context));
        }
        [HttpGet]
        public async Task<IList<Value>> Get()
        {
            var obj=_context.Value.ToListAsync();
            return await obj;
        }
    }
}