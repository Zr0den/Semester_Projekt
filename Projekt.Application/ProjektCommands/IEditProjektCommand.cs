using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.ProjektCommands
{
    public interface IEditProjektCommand
    {
        void Edit(ProjektEditRequestDto projektEditRequestDto);
    }
}
