using CleanArchMVC.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int? id);
        Task<Product> GetProductCategoryAsync(int? id);
        Task<Product> CreateAsync(Product Product);
        Task<Product> UpdateAsync(Product Product);
        Task<Product> RemoveAsync(Product Product);
    }
}
