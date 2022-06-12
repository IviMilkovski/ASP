using ProjekatASP.Application.DataTransfer.Posts;
using ProjekatASP.Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.Posts
{
    public interface IGetAllPostsQuery : IQuery<PostSearch, PagedResponse<PostsDto>>
    {
    }
}
