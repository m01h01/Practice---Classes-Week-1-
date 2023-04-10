using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Classes__Week_1_
{
    internal class Bike
    {
        public enum BikeType { electric, mountain, unicycle }
        string _brand;
        BikeType _type;
        string _color;
        int _numberofwheels;
        public Bike(string brand, BikeType type, string color, int numberofwheels)
        {
            _brand = brand;
            _type = type;
            _color = color;
            _numberofwheels = numberofwheels;
        }

        public string Brand { get => _brand; set => _brand = value; }
        internal BikeType Type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public int Numberofwheels
        {
            get {return _numberofwheels; }
            set
            {
                if (value > 0)
                {
                    _numberofwheels = value;
                }
                else
                {
                    Console.WriteLine("Please enter the positive number");
                }
            }
        }

        public override string ToString()
        {
            return $"Bike : {_brand}, {_type}, {_color}, {_numberofwheels} wheels";
        }
    }
}
