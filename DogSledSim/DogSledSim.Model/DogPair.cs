﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class DogPair : Tuple<Dog, Dog>
    {
        public DogPair(Dog l, Dog r) : base(l, r)
        {
        }

        public IEnumerable<Dog> Dogs { get { return new[] { Item1, Item2 }; } } 
    }
}
