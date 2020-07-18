using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public double OrderSum { get; set; }
        public string UserId { get; set; }
    }
}
