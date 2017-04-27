using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class InspectionRepository
    {
        private readonly ApplicationDbContext _context;

        public InspectionRepository()
        {
            _context = new ApplicationDbContext();
        }

        internal void Create(Inspection inspection)
        {
            _context.Inspection.Add(inspection);
            _context.SaveChanges();
        }

        internal List<Inspection> Read()
        {
            var inspections = _context.Inspection.ToList();

            Console.WriteLine(inspections.ToString());

            return inspections;
        }

        internal void Update(int id)
        {

        }

        internal void Delete(int id)
        {
            var inspection = _context.Inspection.Find(id);
            _context.Inspection.Remove(inspection);
        }
    }
}