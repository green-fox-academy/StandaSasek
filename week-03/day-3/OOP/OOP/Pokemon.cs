﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Pokemon
    {
        public String Name;
        public String Type;
        public String EffectiveAgainst;

        public Pokemon(String name, String type, String effectiveAgainst)
        {
            Name = name;
            Type = type;
            EffectiveAgainst = effectiveAgainst;
        }

        public bool IsEffectiveAgainst(Pokemon anotherPokemon, Pokemon wildPokemon)
        {
            return EffectiveAgainst == anotherPokemon.Type;
        }
    }
}
