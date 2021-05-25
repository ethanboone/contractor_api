using System.Collections.Generic;
using contractor_api.Models;
using contractor_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorsController : ControllerBase
    {
        // extra route: get all jobs given a contractor id
        private readonly ContractorsService _service;
        public ContractorsController(ContractorsService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
        {
            try
            {
                Contractor data = _service.Create(newContractor);
                return Ok(data);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contractor>> GetAll()
        {
            try
            {
                IEnumerable<Contractor> data = _service.GetAll();
                return Ok(data);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Contractor> GetOne(int id)
        {
            try
            {
                Contractor data = _service.GetOne(id);
                return Ok(data);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}