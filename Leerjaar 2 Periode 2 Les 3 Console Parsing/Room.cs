using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    class Room
    {
        public List<Room> destinations { get; private set; }
        public string story { get; private set; }
        public string name { get; private set; }

        public Room(string aName, string aStory)
        {
            destinations = new List<Room>();
            name = aName;
            story = aStory;
        }
        public void AddDestination(Room aRoom)
        {
            destinations.Add(aRoom);
        }
        
    }
}
