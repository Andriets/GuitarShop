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
    public class SidePanelController : ControllerBase
    {
        private ISidePanelService sidePanelService;
        public SidePanelController(ISidePanelService sidePanelService)
        {
            this.sidePanelService = sidePanelService;
        }

        [HttpGet]
        [Route("SidePanels")]
        public IActionResult Get()
        {
            var list = sidePanelService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("SidePanel/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await sidePanelService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("SidePanel/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await sidePanelService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}