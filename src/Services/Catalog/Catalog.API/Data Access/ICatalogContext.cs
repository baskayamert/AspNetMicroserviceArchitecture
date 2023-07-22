using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data_Access
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
