using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModel
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player()
            {
                Name = "Noa",
                Gold = 10,
                CharacterClass = "Mage",
                Level = 1,
                ExperiencePoints = 0,
                HitPoints = 100
            };
            CurrentLocation = new Location()
            {
                XCoordinate = 0,
                YCoordinate = -1,
                Name = "Home",
                Description = "This is your house.",
                ImageName = $"/Engine;component/Images/Locations/Home.png"
            };
        }
    }
}
