using System.Collections.Generic;
using Domain.Abstract;
using Domain.Entities;

namespace Domain.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
