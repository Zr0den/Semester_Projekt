namespace StamData.Application.Ansat.AnsatCommands
{
    public interface ICreateAnsatCommand
    {
        void CreateAnsat(AnsatCreateRequestDto ansatCreateRequestDto);
    }
}
