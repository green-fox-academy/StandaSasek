using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace AircraftCarrier
{
    class Aircraft
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public int MaxAmmo { get; protected set; }
        public int Ammo
        {
            get;
            protected set
            {
                if (Ammo > MaxAmmo)
                {
                    Ammo = MaxAmmo;
                }
                else if (Ammo < 0)
                {
                    Ammo = 0
                }
                else
                {
                    Ammo = value;
                }
                            ;
            }
        }
        public int BaseDamage { get; protected set; }

        public Aircraft(string _name)
        {
            Name = _name;
        }
        public void Fight()
        {
            var maxDamage = Ammo * BaseDamage;
        }
        public void Refill()
        {
            var ammoToRefill = MaxAmmo - Ammo;
            
        }
    }
}
