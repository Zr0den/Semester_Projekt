using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ansatte.Application.Queries
{
    public interface IAnsatGetAllQuery
    {
        IEnumerable<AnsatQueryResultDto> GetAll(string ansatId);
    }
}
