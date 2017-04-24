﻿using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class InspectionsRepository
    {
        private readonly ApplicationDbContext _context;

        public InspectionsRepository()
        {
            _context = new ApplicationDbContext();
        }

        internal List<Inspection> Read()
        {
            var inspections = _context.Inspection.ToList();

            Console.WriteLine(inspections.ToString());

            return inspections;
        }
    }
}