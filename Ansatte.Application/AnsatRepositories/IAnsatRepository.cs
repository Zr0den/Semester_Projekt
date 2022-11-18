using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ansatte.Application.Queries;
using Ansatte.Domain.Model;

namespace Ansatte.Application.Repositories
{
    public interface IAnsatRepository
    {
        void Add(AnsatEntity ansat);
        IEnumerable<AnsatQueryResultDto> GetAll(string ansatId);
        AnsatQueryResultDto Get(int ansatKey, string ansatId);
    }
}
