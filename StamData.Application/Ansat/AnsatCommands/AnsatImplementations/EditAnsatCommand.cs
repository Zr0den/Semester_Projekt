using StamData.Application.Ansat.AnsatRepositories;
using StamData.Domain.Ansat.AnsatDomainServices;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatCommands.AnsatImplementations
{
    public class EditAnsatCommand : IEditAnsatCommand
    {
        private readonly IAnsatRepository _repository;
        private readonly IAnsatDomainService _ansatDomainService;

        public EditAnsatCommand(IAnsatRepository repository, IAnsatDomainService ansatDomainService)
        {
            _repository = repository;
            _ansatDomainService = ansatDomainService;
        }

        void IEditAnsatCommand.EditAnsat(AnsatEditRequestDto requestDto)
        {
            var model = _repository.LoadAnsat(requestDto.AnsatID);

            model.EditAnsat(requestDto.AnsatName, requestDto.AnsatTelefon, requestDto.AnsatType, requestDto.KompetenceIds, _ansatDomainService);

            _repository.UpdateAnsat(model);
        }

        


    }
}
