using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dragracing
{
    class RaceTrack
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;
        Task task1;
        Task task2;
        Task task3;
        private int meters = 400;
        RaceManager rManager = new RaceManager();
        public Car car = new Car("ThreadCar1", Motors.Jondamotor);
        public Car car1 = new Car("ThreadCar2", Motors.Poyota);
        public Car car2 = new Car("ThreadCar3", Motors.Jondamotor);
        public Car car3 = new Car("TaskCar4", Motors.Poyota);
        public Car car4 = new Car("TaskCar5", Motors.Jondamotor);
        public Car car5 = new Car("TaskCar6", Motors.Poyota);

        public void HandleCar()
        {
            rManager.RunCar(car, meters);
        }
        public void HandleCar1()
        {
            rManager.RunCar(car1, meters);
        }
        public void HandleCar2()
        {
            rManager.RunCar(car2, meters);
        }

        public void HandleCar3()
        {
            rManager.RunCar(car3, meters);
        }
        public void HandleCar4()
        {
            rManager.RunCar(car4, meters);
        }
        public void HandleCar5()
        {
            rManager.RunCar(car5, meters);
        }

        //starts the threads and tasks, thread cars goes vs task cars
        public void StartFirstRace()
        {
            //first lab
            thread1 = new Thread(HandleCar);
            thread1.Start();
            task1 = new Task(HandleCar3);
            task1.Start();
        }

        public void StartSecondRace()
        {
            //second lab
            thread2 = new Thread(HandleCar1);
            thread2.Start();
            task2 = new Task(HandleCar4);
            task2.Start();
        }

        public void StartThirdRace()
        {
            //third lab
            thread3 = new Thread(HandleCar2);
            thread3.Start();
            task3 = new Task(HandleCar5);
            task3.Start();
        }
    }
}
