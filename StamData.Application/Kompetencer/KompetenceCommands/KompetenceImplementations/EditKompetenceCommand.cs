using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StamData.Application.Kompetencer.KompetenceRepositories;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Kompetencer.KompetenceCommands.KompetenceImplementations
{
    public class EditKompetenceCommand : IEditKompetenceCommand
    {
        private readonly IKompetenceRepository _kompetenceRepository;

        public EditKompetenceCommand(IKompetenceRepository kompetenceRepository)
        {
            _kompetenceRepository = kompetenceRepository;
        }

        void IEditKompetenceCommand.Edit(KompetenceEditRequestDto requestDto)
        {
            var model = _kompetenceRepository.Load(requestDto.KompetenceID);

            model.Edit(requestDto.KompetenceName, requestDto.Ansatte);

            _kompetenceRepository.Update(model);
        }
    }
}
