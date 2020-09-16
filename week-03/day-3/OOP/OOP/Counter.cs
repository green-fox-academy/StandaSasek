using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Counter
    {
        int counted;

        public int Counted
        {
            get => counted;
            set
            {
                if (value < 0)
                {
                    counted = 0;
                }
                else
                {
                    counted = value;
                };

            }
        }
        public Counter ()
        {
            Counted = 0;
        }
        public int Add (int number)
        {
            Counted = Counted + number;
            return Counted;
        }
        public int Add()
        {
            Counted++;
            return Counted;
        }
        public string Get()
        {
            return Counted.ToString();
        }
        public void Reset()
        {
            Counted = 0;
        }
    }
}
