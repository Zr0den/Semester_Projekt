using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StamData.Application.Kompetencer.KompetenceRepositories;
using StamData.Domain.Ansat.AnsatModel;
using StamData.Domain.Kompetencer.KompetenceModel;


namespace StamData.Application.Kompetencer.KompetenceCommands.KompetenceImplementations
{
    public class CreateKompetenceCommand : ICreateKompetenceCommand
    {
        private readonly IKompetenceRepository _kompetenceRepository;

        public CreateKompetenceCommand(IKompetenceRepository kompetenceRepository)
        {
            _kompetenceRepository = kompetenceRepository;
        }

        void ICreateKompetenceCommand.Create(KompetenceCreateRequestDto kompetenceCreateRequestDto)
        {
            var kompetence = new KompetenceEntity(kompetenceCreateRequestDto.GetHashCode(), kompetenceCreateRequestDto.KompetenceName, kompetenceCreateRequestDto.Ansatte);

            _kompetenceRepository.Add(kompetence);
        }

    }
}
