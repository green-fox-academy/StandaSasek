using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F16 : Aircraft
    {
        public F16(string _name) : base(_name)
        {
            Type = "F16";
            MaxAmmo = 8;
            Ammo = 0;
            BaseDamage = 30;
        }

    }
}
