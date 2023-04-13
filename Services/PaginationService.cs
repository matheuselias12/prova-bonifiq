using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProvaPub.Models;
using ProvaPub.Models.Enum;
using ProvaPub.Repository;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace ProvaPub.Services
{
    public class PaginationService
    {
        private readonly TestDbContext _ctx;
        public PaginationService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public Pagination Pagination(int page, int entidade)
        {
            var result = new Pagination();
            switch (entidade)
            {
                case ((int)Entidades.Product):
                    result = new Pagination() { HasNext = false, TotalCount = 10, 
                        Product = _ctx.Products.OrderBy(p => p.Id).ToPagedList(page, 10).ToList()
                    };
                    break;
                case ((int)Entidades.Customer):
                    result = new Pagination()
                    {
                        HasNext = false,
                        TotalCount = 10,
                        Customer = _ctx.Customers.OrderBy(p => p.Id).ToPagedList(page, 10).ToList()
                    };
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
