namespace WebAPI.Models
{
    public class Inspection
    {
        public string InspectionDate { get; set; }
        public string InspectionStreetAddress { get; set; }
        public string InspectionCity { get; set; }
        public string InspectionState { get; set; }
        public string InspectionZip { get; set; }
        public string InspectionTimeIn { get; set; }
        public string InspectionTimeOut { get; set; }
        public string InspectorLastName { get; set; }
        public string InspectorFirstName { get; set; }
        public string InspectorNumber { get; set; }
    }
}