using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PegsController : ControllerBase
    {
        private IPegsService pegsService;
        public PegsController(IPegsService pegsService)
        {
            this.pegsService = pegsService;
        }

        [HttpGet]
        [Route("Pegss")]
        public IActionResult Get()
        {
            var list = pegsService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("Pegs/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await pegsService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("Pegs/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await pegsService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}