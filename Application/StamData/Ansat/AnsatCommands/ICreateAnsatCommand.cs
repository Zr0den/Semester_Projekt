namespace Application.StamData.Ansat.AnsatCommands
{
    public interface ICreateAnsatCommand
    {
        void CreateAnsat(AnsatCreateRequestDto ansatCreateRequestDto);
    }
}
