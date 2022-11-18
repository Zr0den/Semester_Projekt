﻿using StamData.Application.Ansat.AnsatRepositories;

namespace StamData.Application.Ansat.AnsatQueries.AnsatImplementations
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
