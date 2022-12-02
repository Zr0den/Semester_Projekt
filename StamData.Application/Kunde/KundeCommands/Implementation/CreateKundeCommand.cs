using StamData.Application.Kunde.KundeRepositories;
using StamData.Domain.Kunde.KundeModel;

namespace StamData.Application.Kunde.KundeCommands.Implementation
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
            var kunde = new KundeEntity(kundeCreateRequestDto.KundeUserId, kundeCreateRequestDto.KundeName, kundeCreateRequestDto.KundeAdresse, kundeCreateRequestDto.KundePostNr, kundeCreateRequestDto.KundeCVR);

            _repository.AddKunde(kunde);
        }
    }
}
