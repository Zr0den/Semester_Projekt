using StamData.Application.Ansat.AnsatRepositories;
using StamData.Domain.Kompetencer.KompetenceModel;

namespace StamData.Application.Ansat.AnsatCommands.AnsatImplementations
{
    public class EditAnsatCommand : IEditAnsatCommand
    {
        private readonly IAnsatRepository _repository;

        public EditAnsatCommand(IAnsatRepository repository)
        {
            _repository = repository;
        }

        void IEditAnsatCommand.Edit(AnsatEditRequestDto requestDto)
        {
            var model = _repository.Load(requestDto.AnsatID, requestDto.UserId);

            model.Edit(requestDto.AnsatName, requestDto.AnsatTelefon, requestDto.AnsatType, requestDto.Kompetencer);

            _repository.Update(model);
        }
    }
}
