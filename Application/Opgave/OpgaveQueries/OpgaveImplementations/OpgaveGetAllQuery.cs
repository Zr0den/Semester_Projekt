using Application.Opgave.OpgaveRepositories;

namespace Application.Opgave.OpgaveQueries.OpgaveImplementations
{
    public class OpgaveGetAllQuery : IOpgaveGetAllQuery
    {
        private readonly IOpgaveRepository _repository;

        public OpgaveGetAllQuery(IOpgaveRepository repository)
        {
            _repository = repository;
        }

        IEnumerable<OpgaveQueryResultDto> IOpgaveGetAllQuery.GetAllOpgave()
        {
            return _repository.GetAllOpgave();
        }
    }
}
