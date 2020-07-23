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
    public class ColorController : ControllerBase
    {
        private IColorService colorService;
        public ColorController(IColorService colorService)
        {
            this.colorService = colorService;
        }

        [HttpGet]
        [Route("Colors")]
        public IActionResult Get()
        {
            var list = colorService.GetAll();
            if (list != null)
            {
                return Ok(list);
            }else
            {
                return NotFound("Empty");
            }
        }

        [HttpGet]
        [Route("Color/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await colorService.GetById(id);
            if (obj != null)
            {
                return Ok(obj);
            }else
            {
                return NotFound("None(");
            }
        }

        [HttpPost]
        [Route("Color/{id}")]
        public async Task Delete(int id)
        {
            await colorService.Delete(id);
        }
    }
}