using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.IServices;
using DAL.QueryParameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [Route("Products")]
        public IActionResult Get([FromQuery] ProductParameters productParameters)
        {
            if (!productParameters.ValidPriceRange)
            {
                BadRequest("Price is not valid");
            }
            var list = productService.GetAll(productParameters);
            if (list != null)
            {
                var metadata = new
                {
                    list.TotalCount,
                    list.PageSize,
                    list.CurrentPage,
                    list.TotalPages,
                    list.HasNext,
                    list.HasPrevious
                };
                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
                return Ok(list);
            }        
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("Product/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await productService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("Product/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await productService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}