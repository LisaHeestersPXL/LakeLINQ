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
        // Sea
        new Fish { Name="Nemo",      Species="Clownfish",        Habitat="Sea",   SizeCm=11,   DepthMeters=5,   IsPredator=false },
        new Fish { Name="Sharky",    Species="Great White",      Habitat="Sea",   SizeCm=500,  DepthMeters=200, IsPredator=true  },
        new Fish { Name="Dory",      Species="Blue Tang",        Habitat="Sea",   SizeCm=31,   DepthMeters=40,  IsPredator=false },
        new Fish { Name="Hammy",     Species="Hammerhead Shark", Habitat="Sea",   SizeCm=400,  DepthMeters=80,  IsPredator=true  },
        new Fish { Name="Bubbles",   Species="Pufferfish",       Habitat="Sea",   SizeCm=35,   DepthMeters=30,  IsPredator=false },
        new Fish { Name="Inky",      Species="Moray Eel",        Habitat="Sea",   SizeCm=150,  DepthMeters=50,  IsPredator=true  },
        new Fish { Name="Pearly",    Species="Seahorse",         Habitat="Sea",   SizeCm=14,   DepthMeters=10,  IsPredator=false },
        new Fish { Name="Manta",     Species="Manta Ray",        Habitat="Sea",   SizeCm=450,  DepthMeters=120, IsPredator=false },

        // River
        new Fish { Name="Blinky",    Species="Neon Tetra",       Habitat="River", SizeCm=4,    DepthMeters=2,   IsPredator=false },
        new Fish { Name="Goliath",   Species="Catfish",          Habitat="River", SizeCm=120,  DepthMeters=20,  IsPredator=true  },
        new Fish { Name="Chomper",   Species="Piranha",          Habitat="River", SizeCm=30,   DepthMeters=8,   IsPredator=true  },
        new Fish { Name="Archie",    Species="Archerfish",       Habitat="River", SizeCm=25,   DepthMeters=3,   IsPredator=true  },
        new Fish { Name="Discus",    Species="Discus",           Habitat="River", SizeCm=20,   DepthMeters=5,   IsPredator=false },
        new Fish { Name="Spike",     Species="Gar",              Habitat="River", SizeCm=180,  DepthMeters=15,  IsPredator=true  },

        // Lake
        new Fish { Name="Goldie",    Species="Goldfish",         Habitat="Lake",  SizeCm=10,   DepthMeters=1,   IsPredator=false },
        new Fish { Name="Bass",      Species="Largemouth Bass",  Habitat="Lake",  SizeCm=60,   DepthMeters=6,   IsPredator=true  },
        new Fish { Name="Perchy",    Species="Yellow Perch",     Habitat="Lake",  SizeCm=28,   DepthMeters=9,   IsPredator=false },
        new Fish { Name="Snapper",   Species="Pike",             Habitat="Lake",  SizeCm=130,  DepthMeters=4,   IsPredator=true  },
        new Fish { Name="Tilly",     Species="Tilapia",          Habitat="Lake",  SizeCm=40,   DepthMeters=7,   IsPredator=false },

        // Deep Sea
        new Fish { Name="Lantern",   Species="Lanternfish",      Habitat="Deep",  SizeCm=12,   DepthMeters=900, IsPredator=false },
        new Fish { Name="Grimface",  Species="Anglerfish",       Habitat="Deep",  SizeCm=20,   DepthMeters=1500,IsPredator=true  },
        new Fish { Name="Fang",      Species="Fangtooth",        Habitat="Deep",  SizeCm=16,   DepthMeters=2000,IsPredator=true  },
        new Fish { Name="Blobbert",  Species="Blobfish",         Habitat="Deep",  SizeCm=30,   DepthMeters=900, IsPredator=false },
    };
        }
    }
}
