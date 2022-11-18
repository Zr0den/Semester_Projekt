using StamData.Application.Ansat.AnsatRepositories;
using StamData.Domain.Ansat.AnsatModel;

namespace StamData.Application.Ansat.AnsatCommands.AnsatImplementations
{
    public class CreateAnsatCommand : ICreateAnsatCommand
    {
        private readonly IAnsatRepository _ansatRepository;


        public CreateAnsatCommand(IAnsatRepository ansatRepository)
        {
            _ansatRepository = ansatRepository;
        }

        void ICreateAnsatCommand.Create(AnsatCreateRequestDto ansatCreateRequestDto)
        {
            var ansat = new AnsatEntity(ansatCreateRequestDto.AnsatId, ansatCreateRequestDto.AnsatName, ansatCreateRequestDto.AnsatTelefon, ansatCreateRequestDto.AnsatEmail, ansatCreateRequestDto.AnsatType, ansatCreateRequestDto.KompetenceList);

            _ansatRepository.Add(ansat);
        }
    }
}
