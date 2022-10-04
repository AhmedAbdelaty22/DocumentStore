using BackEnd.Data;
using BackEnd.Models;
using BackEnd.Services.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Services
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly DocumentStoreDbContext context;

        public PriorityRepository(DocumentStoreDbContext _context)
        {
            context = _context;
        }

        public List<Priority> GetAll()
        {
            return context.Priorities.ToList();
        }
    }
}
