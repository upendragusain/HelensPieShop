using HelensPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelensPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public IEnumerable<Pie> Pies { get; set; }
    }
}
