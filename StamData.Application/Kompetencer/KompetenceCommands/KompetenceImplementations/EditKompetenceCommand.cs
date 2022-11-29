
using StamData.Application.Kompetencer.KompetenceRepositories;

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

            model.EditKompetence(requestDto.KompetenceName, requestDto.AnsatEntities);

            _kompetenceRepository.UpdateKompetence(model);
        }
    }
}
