using Application.StamData.Kompetencer.KompetenceRepositories;
using Domain.StamData.Kompetencer.KompetenceModel;

namespace Application.StamData.Kompetencer.KompetenceCommands.KompetenceImplementations
{
    public class CreateKompetenceCommand : ICreateKompetenceCommand
    {
        private readonly IKompetenceRepository _kompetenceRepository;

        public CreateKompetenceCommand(IKompetenceRepository kompetenceRepository)
        {
            _kompetenceRepository = kompetenceRepository;
        }

        void ICreateKompetenceCommand.CreateKompetence(KompetenceCreateRequestDto kompetenceCreateRequestDto)
        {
            var kompetenceEntities = new KompetenceEntity(kompetenceCreateRequestDto.KompetenceName);

            _kompetenceRepository.AddKompetence(kompetenceEntities);
        }

    }
}
