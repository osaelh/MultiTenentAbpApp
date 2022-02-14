using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.Products
{
    public class ProductDto
    {
        public Guid? TenantId { get; private set; }

        public string Name { get; set; }

        public float Price { get; set; }
    }
}
