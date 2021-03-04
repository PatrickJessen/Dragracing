using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dragracing
{
    class RaceManager
    {
        //keeps track of every car
        public void RunCar(Car car, int meters)
        {
            //gets current time in seconds to keep track on how long the loop has taken
            int startTimer = DateTime.Now.Second;
            bool isFinnished = false;
            Thread.Sleep((int)car.TopSpeedTime * 1000);
            while (isFinnished == false)
            {
                //goes 1 meter everytime
                car.Distance += 1;
                Thread.Sleep(1000 / car.TopSpeed); 
                //finnishes the loop if distance is equal or greater than meters
                if (car.Distance >= meters)
                {
                    isFinnished = true;
                }
            }
            //gets current time when the loop is done and calculating the time it took
            int finnishTimer = DateTime.Now.Second - startTimer;
            //stores finnish time
            car.finnishTime = $"{car.Name} finnished in {finnishTimer}";
        }
    }
}
