using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Type { Unknown, Passengers, Cargo } 
    public partial class Train
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Type _typeOfTrain;
        public Type TypeOfTrain { get { return _typeOfTrain; } set { _typeOfTrain = value; } }
        private int _numberOfSeat;
        public int NumberOfSeat { get { return _numberOfSeat; } set { _numberOfSeat = value; } }
        private bool _isOnTrip;
        public bool IsOnTrip { get { return _isOnTrip; } set { _isOnTrip = value; } }
        static Train()
        {
            Console.WriteLine("New train(s) created");
            Console.Write("\a");
        }
        public Train()
        {
            _name = "No name";
            _typeOfTrain = Type.Unknown;
            _numberOfSeat = 0;
            _isOnTrip = false;
        }
        public Train(string name, Type type, int number, bool trip)
        {
            _name = name;
            _typeOfTrain = type;
            _numberOfSeat = number;
            _isOnTrip = trip;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name of train: {_name}\nType of train: {(Type)_typeOfTrain}\nNumber of seats: {_numberOfSeat}\nOn trip? {_isOnTrip}");
        }
        partial void Ring();
        public void DoRing()
        {
            Ring();
        }
    }
}
