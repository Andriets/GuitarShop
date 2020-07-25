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
    public class FeatureController : ControllerBase
    {
        private IFeatureService featureService;
        public FeatureController(IFeatureService featureService)
        {
            this.featureService = featureService;
        }

        [HttpGet]
        [Route("Features")]
        public IActionResult Get()
        {
            var list = featureService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("Feature/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await featureService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("Feature/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await featureService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}