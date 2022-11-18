namespace StamData.Application.Ansat.AnsatCommands
{
    public interface ICreateAnsatCommand
    {
        void Create(AnsatCreateRequestDto ansatCreateRequestDto);
    }
}
