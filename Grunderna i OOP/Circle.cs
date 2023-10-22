using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_i_OOP
{
    internal class Circle
    {
        private double _radie;

        private string _name;
        
        public Circle(double radie, string name)
        {
            _radie = radie;
            _name = name;
            GetArea();
        }

        public void GetArea()
        {
            Console.WriteLine("----------");
            Console.WriteLine(_name + ":");
            Console.WriteLine();
            Console.WriteLine("Radie: " + _radie);
            double area = _radie * _radie * Math.PI;
            Console.WriteLine("Area: " + area);       
        }   
    }
}
