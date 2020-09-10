using HelensPieShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelensPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Infrastructure.Pie> GetAllPies();

        Infrastructure.Pie GetPieById(int pieId);
    }
}
