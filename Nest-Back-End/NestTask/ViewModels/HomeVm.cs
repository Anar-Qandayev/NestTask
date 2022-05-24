using NestTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestTask.HomeVM
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
    }
}
