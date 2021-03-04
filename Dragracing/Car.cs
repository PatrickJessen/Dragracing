using System;
using System.Collections.Generic;
using System.Text;

namespace Dragracing
{
    public enum Motors
    {
        Jondamotor,
        Poyota
    }

    class Car
    {
        public string Name { get; set; }
        public Motors Motor { get; set; }
        public int TopSpeed { get; private set; }
        public float TopSpeedTime { get; private set; }
        public string finnishTime { get; set; }
        public int Distance { get; set; } = 0;

        public Car(string name, Motors motor)
        {
            Name = name;
            Motor = motor;
            GetMotor();
        }

        //gets the motor which you choose once you create an instance of car
        private void GetMotor()
        {
            if (Motor == Motors.Jondamotor)
            {
                TopSpeed = 280;
                TopSpeedTime = 2.5f;
            }
            else if (Motor == Motors.Poyota)
            {
                TopSpeed = 330;
                TopSpeedTime = 4;
            }
        }

        //checks if the car has finnished the race
        public bool HasFinnished()
        {
            if (Distance >= 400)
            {
                return true;
            }
            return false;
        }
    }
}
