using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StamData.Application.Kompetencer.KompetenceCommands
{
    public interface ICreateKompetenceCommand
    {
        void Create(KompetenceCreateRequestDto kompetenceCreateRequestDto);
    }
}
