using NhatNguyen.Data.Infrastructure;
using NhatNguyen.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhatNguyen.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
       
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
