using ProjekatASP.Application.DataTransfer.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.Posts
{
    public interface IGetPostQuery : IQuery<int, ReadPostDto>
    {
    }
}
