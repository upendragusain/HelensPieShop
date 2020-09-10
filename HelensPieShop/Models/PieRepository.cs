using HelensPieShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelensPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PieContext _context;

        public PieRepository(PieContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _context.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(_ => _.PieId == pieId);
        }
    }
}
