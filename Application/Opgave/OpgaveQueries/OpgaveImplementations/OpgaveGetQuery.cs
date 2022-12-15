using Application.Opgave.OpgaveRepositories;

namespace Application.Opgave.OpgaveQueries.OpgaveImplementations
{
    public class OpgaveGetQuery : IOpgaveGetQuery
    {
        private readonly IOpgaveRepository _repository;

        public OpgaveGetQuery(IOpgaveRepository repository)
        {
            _repository = repository;
        }

        OpgaveQueryResultDto IOpgaveGetQuery.GetOpgave(int opgaveId)
        {
            return _repository.GetOpgave(opgaveId);
        }
    }
}
