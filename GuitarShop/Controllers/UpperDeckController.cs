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
    public class UpperDeckController : ControllerBase
    {
        private IUpperDeckService upperDeckService;

        public UpperDeckController(IUpperDeckService upperDeckService)
        {
            this.upperDeckService = upperDeckService;
        }

        [HttpGet]
        [Route("UpperDecks")]
        public IActionResult Get()
        {
            var list = upperDeckService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("UpperDeck/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await upperDeckService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("UpperDeck/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await upperDeckService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}