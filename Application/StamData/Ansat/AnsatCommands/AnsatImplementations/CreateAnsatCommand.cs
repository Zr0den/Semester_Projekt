using Application.StamData.Ansat.AnsatRepositories;
using Domain.StamData.Ansat.AnsatModel;

namespace Application.StamData.Ansat.AnsatCommands.AnsatImplementations
{
    public class CreateAnsatCommand : ICreateAnsatCommand
    {
        private readonly IAnsatRepository _ansatRepository;


        public CreateAnsatCommand(IAnsatRepository ansatRepository)
        {
            _ansatRepository = ansatRepository;
        }

        void ICreateAnsatCommand.CreateAnsat(AnsatCreateRequestDto ansatCreateRequestDto)
        {
            var ansat = new AnsatEntity(ansatCreateRequestDto.UserID, ansatCreateRequestDto.AnsatName, ansatCreateRequestDto.AnsatTelefon, ansatCreateRequestDto.AnsatType);

            _ansatRepository.AddAnsat(ansat);
        }



    }
}
