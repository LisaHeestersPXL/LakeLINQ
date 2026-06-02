using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakeLINQ.Domain
{
    public class Fish
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }  
        public int SizeCm { get; set; }
        public int DepthMeters { get; set; }
        public bool IsPredator { get; set; }
    }
}
