using Ansatte.Domain.Model;

namespace Kompetencer.Domain.Model
{
    public class KompetenceEntity
    {
        public int KompetenceKey { get; }
        public string Kompetence { get; private set; }
        public string KompetenceType { get; private set; }
        public ICollection<AnsatEntity> Ansatte { get; private set; }
    }

}
