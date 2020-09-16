using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Sharpie
    {
        string color;
        double width;
        double inkAmount;
        public string Color { get => color; set => color = value; }
        public double Width { get => width; set => width = value; }
        public double InkAmount { get => inkAmount; set => inkAmount = value; }
        public Sharpie(string color, double width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }
        public void Use()
        {
            InkAmount = InkAmount - 0.1 * width;
        }
    }
}
