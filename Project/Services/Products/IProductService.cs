﻿using Project.Data.Models;
using Project.Models;

namespace Project.Services
{
    public interface IProductService
    {
        Task AddProductAsync(AddProductViewModel model);
        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<IEnumerable<ProductViewModel>> GetAllAsync(string type);
        Task DeleteAsync(int productId);

        Task<Item> GetForEditAsync(int productId);

        Task EditProductAsync(Item model);
        Task<IEnumerable<ProductViewModel>> GetProductByStringAsync(string text);

        Task<Item> GetProductAsync(int productId);
    }
}
