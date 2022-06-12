using ProjekatASP.Application.DataTransfer.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.Categories
{
    public interface IGetCategoryQuery : IQuery<int, ReadCategoryDto>
    {
    }
}
