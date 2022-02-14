using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace MainApp.Products
{
    public class ProductAppService : DomainService
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductAppService(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> CreateAsync(string name, float price)
        {
            var product = new Product(name, price, CurrentTenant.Id);
            return await _productRepository.InsertAsync(product);
        }

        public async Task<List<Product>> GetList()
        {
            var products = await _productRepository.GetListAsync();
            return products;
        }
    }
}
