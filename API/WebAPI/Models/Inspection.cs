using System;

namespace WebAPI.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
    }
}