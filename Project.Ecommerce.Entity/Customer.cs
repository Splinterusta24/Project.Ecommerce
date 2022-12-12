using Project.Ecommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Ecommerce.Entity
{
    public class Customer:EntityBase,IEntity
    {
        public string Code { get; set; }
    }
}
