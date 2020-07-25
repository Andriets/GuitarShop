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
    public class LowerDeckController : ControllerBase
    {
        private ILowerDeckService lowerDeckService;
        public LowerDeckController(ILowerDeckService lowerDeckService)
        {
            this.lowerDeckService = lowerDeckService;
        }

        [HttpGet]
        [Route("LowerDecks")]
        public IActionResult Get()
        {
            var list = lowerDeckService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("LowerDeck/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await lowerDeckService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("LowerDeck/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await lowerDeckService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}