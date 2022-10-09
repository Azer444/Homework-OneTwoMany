using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }
        public List<FlowerExpert> FlowerExperts  { get; set; }
        
    }
}
