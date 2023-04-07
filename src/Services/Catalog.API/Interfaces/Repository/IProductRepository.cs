using Catalog.API.Models;
using MongoRepo.Interfaces.Repository;

namespace Catalog.API.Interfaces.Repository
{
    public interface IProductRepository:ICommonRepository<Product>
    {
    }
}
