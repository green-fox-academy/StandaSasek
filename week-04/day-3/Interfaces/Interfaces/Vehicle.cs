using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Interfaces
{
    public abstract class Vehicle
    {
        protected int length;
        protected int speed;
        protected string name;

        protected Vehicle(int length, int speed, string name)
        {
            this.length = length;
            this.speed = speed;
            this.name = name;
        }
    }
}
