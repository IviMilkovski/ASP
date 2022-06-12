using ProjekatASP.Application.DataTransfer.AuditLogs;
using ProjekatASP.Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Queries.AuditLogs
{
    public interface IGetAuditLogsQuery : IQuery<AuditLogSearch, PagedResponse<AuditLogDto>>
    {
    }
}
