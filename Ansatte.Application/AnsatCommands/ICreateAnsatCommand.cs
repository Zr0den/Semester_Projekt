using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ansatte.Application.Commands
{
    public interface ICreateAnsatCommand
    {
        void Create(AnsatCreateRequestDto ansatCreateRequestDto);
    }
}
