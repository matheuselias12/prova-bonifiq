using ProvaPub.Models;
using ProvaPub.Repository;
using X.PagedList;

namespace ProvaPub.Services
{
	public class ProductService
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public ProductList  ListProducts(int page)
		{
			return new ProductList() {  HasNext=false, TotalCount = 10, Products = _ctx.Products.OrderBy(p => p.Id).ToPagedList(page, 10).ToList() };
		}

	}
}
