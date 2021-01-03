using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ooadServer.DTO;
using ooadServer.DAL;
using System.Threading.Tasks;

namespace ooadServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KHOAController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public KHOAController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<KHOA> Get()
        {
            return _dataAccessProvider.GetKHOARecords();
        }
        
    }
}
