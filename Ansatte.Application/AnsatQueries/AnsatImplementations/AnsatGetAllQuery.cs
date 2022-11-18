using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ansatte.Application.Repositories;

namespace Ansatte.Application.Queries.Implementation
{
    public class AnsatGetAllQuery : IAnsatGetAllQuery
    {
        private readonly IAnsatRepository _repository;

        public AnsatGetAllQuery(IAnsatRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<AnsatQueryResultDto> IAnsatGetAllQuery.GetAll(string ansatId)
        {
            return _repository.GetAll(ansatId);
        }
    }
}
