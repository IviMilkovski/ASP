using ProjekatASP.Application.DataTransfer.Users;
using ProjekatASP.Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.Users
{
    public interface IGetUsersQuery : IQuery<UserSearch, PagedResponse<UserDto>>
    {

    }
}
