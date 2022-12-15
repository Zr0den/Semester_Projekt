using Application.StamData.Kunde.KundeRepositories;
using Domain.StamData.Kunde.KundeModel;

namespace Application.StamData.Kunde.KundeCommands.Implementation
{
    public class CreateKundeCommand : ICreateKundeCommand
    {
        private readonly IKundeRepository _repository;

        public CreateKundeCommand(IKundeRepository repository)
        {
            _repository = repository;
        }

        void ICreateKundeCommand.CreateKunde(KundeCreateRequestDto kundeCreateRequestDto)
        {
            var kunde = new KundeEntity(kundeCreateRequestDto.KUserID, kundeCreateRequestDto.KundeName, kundeCreateRequestDto.KundeAdresse, kundeCreateRequestDto.KundePostNr, kundeCreateRequestDto.KundeCVR);

            _repository.AddKunde(kunde);
        }
    }
}
