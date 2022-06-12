using ProjekatASP.Application.DataTransfer.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.Comments
{
    public interface IGetCommentQuery : IQuery<int, ReadCommentDto>
    {
    }
}
