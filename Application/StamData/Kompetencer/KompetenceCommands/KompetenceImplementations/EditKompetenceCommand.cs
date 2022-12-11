using Application.StamData.Kompetencer.KompetenceRepositories;

namespace Application.StamData.Kompetencer.KompetenceCommands.KompetenceImplementations
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
