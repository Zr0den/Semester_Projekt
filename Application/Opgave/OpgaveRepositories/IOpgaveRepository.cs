using Application.Opgave.OpgaveQueries;
using Domain.Opgave.OpgaveModel;

namespace Application.Opgave.OpgaveRepositories
{
    public interface IOpgaveRepository
    {
        void AddOpgave(OpgaveEntity opgave);
        IEnumerable<OpgaveQueryResultDto> GetAllOpgave();
        OpgaveQueryResultDto GetOpgave(int opgaveId);
        OpgaveEntity LoadOpgave(int opgaveId);
        void UpdateOpgave(OpgaveEntity model);
    }
}
