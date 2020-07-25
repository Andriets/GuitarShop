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
    public class NumberOfFretsController : ControllerBase
    {
        private INumberOfFretsService numberOfFretsService;
        public NumberOfFretsController(INumberOfFretsService numberOfFretsService)
        {
            this.numberOfFretsService = numberOfFretsService;
        }

        [HttpGet]
        [Route("NumberOfFretss")]
        public IActionResult Get()
        {
            var list = numberOfFretsService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("NumberOfFrets/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await numberOfFretsService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("NumberOfFrets/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await numberOfFretsService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}