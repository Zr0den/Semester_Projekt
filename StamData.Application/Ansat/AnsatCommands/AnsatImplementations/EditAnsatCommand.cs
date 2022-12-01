﻿using StamData.Application.Ansat.AnsatRepositories;
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

        void IEditAnsatCommand.EditAnsat(AnsatEditRequestDto requestDto)
        {
            var model = _repository.LoadAnsat(requestDto.AnsatID);

            model.EditAnsat(requestDto.AnsatName, requestDto.AnsatTelefon, requestDto.AnsatType);

            _repository.UpdateAnsat(model);
        }
    }
}
