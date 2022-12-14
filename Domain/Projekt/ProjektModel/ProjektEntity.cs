using Domain.Booking.BookingModel;
using Domain.Projekt.ProjektDomainServices;
using Domain.StamData.Ansat.AnsatModel;
using Domain.StamData.Kunde.KundeModel;

namespace Domain.Projekt.ProjektModel
{
    public class ProjektEntity
    {
        public int ProjektID { get; }
        public string ProjektName { get; private set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime EstimeretSlutDato { get; set; }
        //public virtual ICollection<BookingEntity> BookingEntities { get; set; }
        


        public string UserID { get; set; }
        //public virtual AnsatEntity? AID { get; set; }
        public int KundeID { get; set; }
        public virtual KundeEntity? KID { get; set; }

        internal ProjektEntity()
        {

        }

        public ProjektEntity(
            string projektName, string userId, int kundeId, IProjektDomainService projektDomainService)
        {
            ProjektName = projektName;
            UserID = userId;
            KundeID = kundeId;
            OprettelsesDato = DateTime.Now;
            KID = projektDomainService.GetKunde(kundeId);
        }
        
        public void Edit(string projektName)
        {
            ProjektName = projektName;
        }
    }
}
