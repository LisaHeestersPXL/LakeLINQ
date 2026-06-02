using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LakeLINQ.Domain;

namespace LakeLINQ.Infrastructure
{
    public class FishRepository
    {
        public List<Fish> GetAll()
        {
            return new List<Fish>
            {
                new Fish { Name="Nemo", Species="Clownfish", Habitat="Sea", SizeCm=11, DepthMeters=5, IsPredator=false },
                new Fish { Name="Sharky", Species="Great White", Habitat="Sea", SizeCm=500, DepthMeters=200, IsPredator=true },
                new Fish { Name="Blinky", Species="Neon Tetra", Habitat="River", SizeCm=4, DepthMeters=2, IsPredator=false },
                new Fish { Name="Goliath", Species="Catfish", Habitat="River", SizeCm=120, DepthMeters=20, IsPredator=true },
                new Fish { Name="Goldie", Species="Goldfish", Habitat="Lake", SizeCm=10, DepthMeters=1, IsPredator=false }
            };
        }
    }
}
