using Abc.Data.GroupProjectClasses.Nora;
using Abc.Infra;

namespace Abc.Soft.Web;
public static class ProductsInUserInventoryApi
{
    public static IEndpointRouteBuilder MapProductsInUserInventoryApi(this IEndpointRouteBuilder app)
        => app.MapCrudApi<ProductsInUserInventory, IProductsInUserInventoryRepo>("/api/productsinuserinventory");
}