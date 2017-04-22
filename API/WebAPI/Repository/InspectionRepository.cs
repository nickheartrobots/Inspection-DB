using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class InspectionRepository
    {
        internal Inspection Create()
        {
            var inspection = new Inspection
            {

            };
            return inspection;
        }

        internal List<Inspection> Retrieve()
        {
            var inspectionPath = HostingEnvironment.MapPath(@"~/App_Data/inspection.json");
            var inspectionJson = System.IO.File.ReadAllText(inspectionPath);
            var inspections = JsonConvert.DeserializeObject<List<Inspection>>(inspectionJson);

            //var addressPath = HostingEnvironment.MapPath(@"~/App_Data/address.json");
            //var addressJson = System.IO.File.ReadAllText(addressPath);
            //var addresses = JsonConvert.DeserializeObject<List<Inspection>>(addressJson);

            return inspections;
        }

        internal Inspection Save(Inspection inspection)
        {
            var inspections = Retrieve();
            var maxId = inspections.Max(i => i.Id);
            inspection.Id = maxId + 1;
            inspections.Add(inspection);

            WriteData(inspections);
            return inspection;
        }

        internal Inspection Save(int id, Inspection inspection)
        {
            var inspections = Retrieve();

            var itemIndex = inspections.FindIndex(i => i.Id == inspection.Id);
            if (itemIndex > 0)
            {
                inspections[itemIndex] = inspection;
            }
            else
            {
                return null;
            }

            WriteData(inspections);
            return inspection;
        }

        private bool WriteData(List<Inspection> inspections)
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/product.json");

            var json = JsonConvert.SerializeObject(inspections, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);

            return true;
        }
    }
}