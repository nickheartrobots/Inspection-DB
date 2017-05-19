using Common.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class VehicleRepository
    {
        private readonly ApplicationDbContext _context;

        public VehicleRepository()
        {
            _context = new ApplicationDbContext();
        }

        internal void Create(Vehicle vehicle)
        {
            _context.Vehicle.Add(vehicle);
            _context.SaveChanges();
        }

        internal List<Vehicle> Read()
        {
            var vehicles = _context.Vehicle.ToList();
            return vehicles;
        }
    }
}