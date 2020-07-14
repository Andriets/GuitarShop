using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class BaseEntity : IEntity<int>
    {
        public int Id { get; set; }
    }
}
