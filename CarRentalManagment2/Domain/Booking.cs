namespace CarRentalManagement2.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut {  get; set; }
        public DateTime DateIn { get; set; }
        public int VechicleId { get; set; }
        public int CustomerId { get; set; }


    }
}