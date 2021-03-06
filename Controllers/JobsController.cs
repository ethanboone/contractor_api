using System.Collections.Generic;
using contractor_api.Models;
using contractor_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Job_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        // extra route: get all contractors given a job id
        private readonly JobsService _service;
        public JobsController(JobsService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                Job data = _service.Create(newJob);
                return Ok(data);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetAll()
        {
            try
            {
                IEnumerable<Job> data = _service.GetAll();
                return Ok(data);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Job> GetOne(int id)
        {
            try
            {
                Job data = _service.GetOne(id);
                return Ok(data);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}