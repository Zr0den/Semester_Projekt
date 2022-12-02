
using Projekt.Application.ProjektQueries;
using Projekt.Domain.ProjektModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektRepositories
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
