using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;

namespace CleanArchitecture.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productInputModels)
        {
            var product = new Product();
            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);
            return new ProductViewModel(product.Title, product.Price);
        }
    }
}