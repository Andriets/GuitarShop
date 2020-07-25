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
    public class SizeController : ControllerBase
    {
        private ISizeService sizeService;
        public SizeController(ISizeService sizeService)
        {
            this.sizeService = sizeService;
        }

        [HttpGet]
        [Route("Sizes")]
        public IActionResult Get()
        {
            var list = sizeService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("Size/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await sizeService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("Size/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await sizeService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}