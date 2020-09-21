using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Counter
    {
        int counted;
        int setNumber;

        public int SetNumber { get => setNumber; private set => setNumber = value; }

        public int Counted { get => counted; private set => counted = value; }

        public Counter(int startingNumber = 0)
        {
            SetNumber = startingNumber;
            Counted = startingNumber;
        }
        public void Add(int number)
        {
            Counted = Counted + number;
        }
        public void Add()
        {
            Counted++;
        }
        public string Get()
        {
            return Counted.ToString();
        }
        public void Reset()
        {
            Counted = SetNumber;
        }
    }
}


