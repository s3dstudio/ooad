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
    public class SINHVIENController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public SINHVIENController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<SINHVIEN> Get()
        {
            return _dataAccessProvider.GetSINHVIENRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] SINHVIEN k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddSINHVIENRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public SINHVIEN Details(string id)
        {
            return _dataAccessProvider.GetSINHVIENSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] SINHVIEN k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateSINHVIENRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetSINHVIENSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteSINHVIENRecord(id);
            return Ok();
        }
    }
}
