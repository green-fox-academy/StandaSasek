using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Sharpie
    {
        double inkAmount;
        public string Color { get; private set; }
        public double Width { get; private set; }
        public double InkAmount
        {
            get
            {
                return inkAmount;
            }
            private set
            {
                if (value <= 0)
                {
                    inkAmount = 0;
                }
                else
                {
                    inkAmount = value;
                }
            }
        }
        public Sharpie(string color, double width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }
        public void Use()
        {
            InkAmount -= Width;
        }
        public double InkAmountSharpie()
        {
            return InkAmount;
        }
    }
}
