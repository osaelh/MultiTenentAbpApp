using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace MainApp.Products
{
    public interface IProductAppService : ICrudAppService<ProductDto, Guid>
    {
    }
}
