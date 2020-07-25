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
    public class ProducingCountryController : ControllerBase
    {
        private IProducingCountryService producingCountryService;
        public ProducingCountryController(IProducingCountryService producingCountryService)
        {
            this.producingCountryService = producingCountryService;
        }

        [HttpGet]
        [Route("ProducingCountries")]
        public IActionResult Get()
        {
            var list = producingCountryService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("ProducingCountry/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await producingCountryService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("ProducingCountry/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await producingCountryService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}