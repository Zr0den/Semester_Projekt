using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StamData.Application.Kompetencer.KompetenceQueries
{
    public interface IKompetenceGetQuery
    {
        KompetenceQueryResultDto GetKompetence(int kompetenceId);
    }
}
