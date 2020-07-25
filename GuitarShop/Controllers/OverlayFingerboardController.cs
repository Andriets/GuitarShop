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
    public class OverlayFingerboardController : ControllerBase
    {
        private IOverlayFingerboardService overlayFingerboardService;
        public OverlayFingerboardController(IOverlayFingerboardService overlayFingerboardService)
        {
            this.overlayFingerboardService = overlayFingerboardService;
        }

        [HttpGet]
        [Route("OverlayFingerboards")]
        public IActionResult Get()
        {
            var list = overlayFingerboardService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("OverlayFingerboard/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await overlayFingerboardService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("OverlayFingerboard/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await overlayFingerboardService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}