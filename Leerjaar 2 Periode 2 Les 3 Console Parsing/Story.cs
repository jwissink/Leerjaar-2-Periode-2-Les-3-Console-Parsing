using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    class Story
    {
        private Room startRoom;
        private Room currentRoom;
        private List<Room> rooms = new List<Room>();
        public Story()
        {
            Room corridor   = new Room("Corridor", "You're in a shiny corridor, the atmosphere is daft and you forgot why you even came here");
            Room library    = new Room("Library", "You enter the library, the fire place is lit, giving off a comfortable hue");
            Room kitchen    = new Room("Kitchen", "You enter the kitchen, there is food on the counter, but it looks like it has been there for ages");
            Room upstairs   = new Room("Hallway", "You ascent the stairs, the rug is old and daft, still there is no sign of life");
            Room bedRoom    = new Room("Bedroom", "You enter the bedroom, clearly time for a little nap");
            Room sleep      = new Room("Sleep", "You fall asleep, and you never wake again.... TUMTUMTUUUUM");


            corridor.AddDestination(library);
            library.AddDestination(corridor);
            corridor.AddDestination(kitchen);
            kitchen.AddDestination(corridor);
            corridor.AddDestination(upstairs);
            bedRoom.AddDestination(upstairs);
            upstairs.AddDestination(bedRoom);
            bedRoom.AddDestination(sleep);
            upstairs.AddDestination(corridor);

            startRoom = corridor;
            currentRoom = startRoom;


        }
        public void Run()
        {
            Console.WriteLine($"You're in the {currentRoom.name}\n");
            Console.WriteLine(currentRoom.story + "\n");
            Console.WriteLine("Where do you want to go?");
            for(int i = 0; i < currentRoom.destinations.Count; i++)
            {
                Console.WriteLine($"{i} - {currentRoom.destinations[i].name}");
            }
            int choice = AskForInput(currentRoom.destinations.Count);
            currentRoom = currentRoom.destinations[choice];
            
        }
        private int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if(input < maxNumber)
                {
                    return input;
                }
                Console.WriteLine("Ongeldige input: Optie niet beschikbaar");
            }
            Console.WriteLine("Ongeldige input: Geef een getal op");
            return AskForInput(maxNumber);
        }

    }
}
