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
    public class OrderController : ControllerBase
    {
        private IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        [Route("Orders")]
        public IActionResult Get()
        {
            var list = orderService.GetAll();
            if (list != null)
                return Ok(list);
            else
                return NotFound("Empty");
        }

        [HttpGet]
        [Route("Order/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var obj = await orderService.GetById(id);
            if (obj != null)
                return Ok(obj);
            else
                return NotFound("None(");
        }

        [HttpDelete]
        [Route("Order/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await orderService.Delete(id);
            if (res)
                return Ok("Success");
            else
                return NotFound("Object not found");
        }
    }
}