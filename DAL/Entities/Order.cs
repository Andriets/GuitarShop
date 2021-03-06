﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Order : BaseEntity
    {
        public double OrderSum { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
