using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dragracing
{
    class Gui
    {
        RaceTrack track = new RaceTrack();

        public void RaceLoop()
        {
            bool isGaveOver = false;
            track.StartFirstRace();
            Console.WriteLine("first race started");
            while (isGaveOver == false)
            {
                if (track.car.HasFinnished() && track.car3.HasFinnished() && track.car3.finnishTime != null && track.car.finnishTime != null)
                {
                    Console.WriteLine(track.car.finnishTime);
                    Console.WriteLine(track.car3.finnishTime);
                    track.car.Distance = 0;
                    track.car3.Distance = 0;
                    track.StartSecondRace();
                    Console.WriteLine("second race started");
                }
                if (track.car1.HasFinnished() && track.car4.HasFinnished() && track.car4.finnishTime != null && track.car1.finnishTime != null)
                {
                    Console.WriteLine(track.car1.finnishTime);
                    Console.WriteLine(track.car4.finnishTime);
                    track.car1.Distance = 0;
                    track.car4.Distance = 0;
                    track.StartThirdRace();
                    Console.WriteLine("third race started");
                }
                if (track.car2.HasFinnished() && track.car5.HasFinnished() && track.car5.finnishTime != null && track.car2.finnishTime != null)
                {
                    Console.WriteLine(track.car2.finnishTime);
                    Console.WriteLine(track.car5.finnishTime);
                    track.car2.Distance = 0;
                    track.car5.Distance = 0;
                    isGaveOver = true;
                }
            }
        }
    }
}
