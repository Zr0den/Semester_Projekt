using StamData.Application.Kompetencer.KompetenceRepositories;
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

        void ICreateKompetenceCommand.CreateKompetence(KompetenceCreateRequestDto kompetenceCreateRequestDto)
        {
            var kompetenceEntities = new KompetenceEntity(kompetenceCreateRequestDto.GetHashCode(), kompetenceCreateRequestDto.KompetenceName, kompetenceCreateRequestDto.AnsatEntities);

            _kompetenceRepository.AddKompetence(kompetenceEntities);
        }

    }
}
