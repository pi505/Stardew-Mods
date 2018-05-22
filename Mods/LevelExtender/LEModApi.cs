﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;
using StardewModdingAPI;

namespace LevelExtender
{
    public class LEModApi
    {

        public LEModApi()
        {

        }

        //This value will offset spawn-rate by the specified amount (1 second intervals)
        public double overSR = -1.0;

        public void spawn_rate(double osr)
        {
            overSR = osr;
        }
    }
}
