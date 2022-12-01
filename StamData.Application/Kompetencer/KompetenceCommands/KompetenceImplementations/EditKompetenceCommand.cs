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

        void IEditKompetenceCommand.EditKompetence(KompetenceEditRequestDto requestDto)
        {
            var model = _kompetenceRepository.LoadKompetence(requestDto.KompetenceID);

            model.EditKompetence(requestDto.KompetenceName);

            _kompetenceRepository.UpdateKompetence(model);
        }
    }
}
