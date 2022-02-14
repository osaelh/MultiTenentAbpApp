using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace MainApp.Products
{
    public class Product : AggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; private set; }

        public string Name { get; set; }

        public float Price { get; set; }

        protected Product()
        {
            //This parameterless constructor is needed for ORMs
        }

        public Product(string name, float price, Guid? tenantId)
        {
            Name = name;
            Price = price;
            TenantId = tenantId; //Set in the constructor
        }
    }
}
