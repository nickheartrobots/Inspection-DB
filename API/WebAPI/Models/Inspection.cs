namespace WebAPI.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int AddressId { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public Address Address { get; set; }
        public Inspector Inspector { get; set; }
    }
}