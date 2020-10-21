using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Services
{
    public interface IProductService
    {
        ProductViewModel GetById(int id);
    }
}