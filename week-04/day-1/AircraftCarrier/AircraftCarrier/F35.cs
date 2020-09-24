using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35(string _name) : base(_name)
        {
            Type = "F35";
            MaxAmmo = 12; 
            Ammo = 0;
            BaseDamage = 50;
        }
    
    }
}
