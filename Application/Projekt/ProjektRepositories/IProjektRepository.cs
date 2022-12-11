using Application.Projekt.ProjektQueries;
using Domain.Projekt.ProjektModel;

namespace Application.Projekt.ProjektRepositories
{
    public interface IProjektRepository
    {

        void AddProjekt(ProjektEntity projekt);
        IEnumerable<ProjektQueryResultDto> GetAllProjekt();
        ProjektQueryResultDto GetProjekt(int projektId);
        ProjektEntity LoadProjekt(int projektId);
        void UpdateProjekt(ProjektEntity model);
    }
}
