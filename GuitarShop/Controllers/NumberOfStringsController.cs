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
    public class NumberOfStringsController : ControllerBase
    {
        private INumberOfStringsService numberOfStringsService;
        public NumberOfStringsController(INumberOfStringsService numberOfStringsService)
        {
            this.numberOfStringsService = numberOfStringsService;
        }

        [HttpGet]
        [Route("NumberOfStringss")]
        public IActionResult Get()
        {
            var list = numberOfStringsService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("NumberOfStrings/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await numberOfStringsService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("NumberOfStrings/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await numberOfStringsService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}