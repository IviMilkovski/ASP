using ProjekatASP.Application.DataTransfer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.Users
{
    public interface IGetUserQuery : IQuery<int, ReadUserDto>
    {
    }
}
