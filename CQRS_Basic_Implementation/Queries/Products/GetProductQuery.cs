using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Basic_Implementation.Queries.Products
{
    public class GetProductQuery
    {
        public int Id { get; }

        public GetProductQuery(int id)
        {
            Id = id;
        }
    }
}
