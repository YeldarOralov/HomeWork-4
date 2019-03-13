using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train1 = new Train();
            train1.GetInfo();

            int numberOfTrain = 5;

            Train[] train2 = new Train[numberOfTrain];
            for(int i =0;i< numberOfTrain; i++)
            {
                train2[i] = new Train
                {
                    Name = "123asd",
                    TypeOfTrain = Type.Cargo,
                    NumberOfSeat = i+10,
                    IsOnTrip = true
                };
            }
            foreach(Train tr in train2)
            {
                tr.GetInfo();
            }

            train1.DoRing();
            Console.ReadLine();
        }
    }
}
