

using DatabaseApp.Entities;
using DatabaseApp.Repositories;

namespace DatabaseApp.Services;

internal class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly CategoryService _categoryService;

    public ProductService(ProductRepository productRepository, CategoryService categoryService)
    {
        _productRepository = productRepository;
        _categoryService = categoryService;
    }


    public ProductEntity CreateProduct(string title, decimal price, string categoryName) 
    {
        var categoryEntity = _categoryService.CreateCategory(categoryName);

        var productEntity = _productRepository.Create(new ProductEntity
        {
            Title = title,
            Price = price,
            CategoryId = categoryEntity.Id,
        });

        return productEntity;
    }



    public ProductEntity GetProductById(int Id)
    {
        var productEntity = _productRepository.Get(x => x.Id == Id);

        return productEntity;
    }


    public IEnumerable<ProductEntity> GetProducts()
    {
        var products = _productRepository.GetAll();

        return products;
    }


    public ProductEntity UpdateProduct(ProductEntity productEntity)
    {
        var updatedProductEntity = _productRepository.Update(x => x.Id == productEntity.Id, productEntity);

        return updatedProductEntity;
    }


    public void DeleteProduct(int id)
    {
        _productRepository.Delete(x => x.Id == id);
    }

}
