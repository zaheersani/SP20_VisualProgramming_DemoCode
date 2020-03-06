using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Box
    {
        private double length; // Length of a box
        private double breadth; // Breadth of a box
        private double height; // Height of a box
        public Box(double length, double height, double breadth) {
            this.length = length;
            this.height = height;
            this.breadth = breadth;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }

        public static Box operator +(Box b1, Box b2)
        {
            double len = b1.length + b2.length;
            double height = b1.height+ b2.height;
            double breadth = b1.breadth + b2.breadth;
            return new Box(len, height, breadth);
        }

        public static Box operator -(Box b1, Box b2)
        {
            return new Box(5, 5, 5);
        }

        public static bool operator >(Box box1, Box box2)
        {
            if(box1.getVolume() > box2.getVolume())
                return true;
            return false;
        }

        public static bool operator <(Box b1, Box b2)
        {
            if (b1.getVolume() < b2.getVolume())
                return true;
            return false;
        }
    }
}

