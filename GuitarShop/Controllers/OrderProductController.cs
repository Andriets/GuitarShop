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
    public class OrderProductController : ControllerBase
    {
        private IOrderProductService orderProductService;
        public OrderProductController(IOrderProductService orderProductService)
        {
            this.orderProductService = orderProductService;
        }

        [HttpGet]
        [Route("OrderProducts")]
        public IActionResult Get()
        {
            var list = orderProductService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("OrderProduct/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await orderProductService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("OrderProduct/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await orderProductService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}