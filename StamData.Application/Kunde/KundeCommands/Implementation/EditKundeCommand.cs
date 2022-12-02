using StamData.Application.Kunde.KundeRepositories;

namespace StamData.Application.Kunde.KundeCommands.Implementation
{
    public class EditKundeCommand : IEditKundeCommand
    {
        private readonly IKundeRepository _repository;

        public EditKundeCommand(IKundeRepository repository)
        {
            _repository = repository;
        }

        void IEditKundeCommand.EditKunde(KundeEditRequestDto requestDto)
        {
            var model = _repository.LoadKunde(requestDto.KundeID);

            model.EditKunde(requestDto.KundeName, requestDto.KundeAdresse, requestDto.KundePostNr, requestDto.KundeCVR);

            _repository.UpdateKunde(model);
        }
    }
}
