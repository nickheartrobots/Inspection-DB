using Common.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class InspectorRepository
    {
        private readonly ApplicationDbContext _context;

        public InspectorRepository()
        {
            _context = new ApplicationDbContext();
        }

        internal void Create(Inspector inspector)
        {
            _context.Inspector.Add(inspector);
            _context.SaveChanges();
        }


        internal List<Inspector> Read()
        {
            var inspectors = _context.Inspector.ToList();
            return inspectors;
        }
    }
}