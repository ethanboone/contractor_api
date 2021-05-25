using System.Collections.Generic;
using contractor_api.Models;
using contractor_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorJobController : ControllerBase
    {
        private readonly ContractorJobService _service;

        public ContractorJobController(ContractorJobService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<ContractorJob> Create([FromBody] ContractorJob newCB)
        {
            try
            {
                ContractorJob data = _service.Create(newCB);
                return Ok(data);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ContractorJob> GetOne(int id)
        {
            try
            {
                ContractorJob data = _service.GetOne(id);
                return Ok(data);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                string data = _service.Delete(id);
                return Ok(data);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}