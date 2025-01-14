﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave.Classes.Interfaces
{
    public interface ICookController
    {
        void StartCooking(int power, int time);

        int GetMaxPower();
        void Stop();
        int GetTimeRemaining();
        public void ChangeCookingTime(int time);
    }
}
