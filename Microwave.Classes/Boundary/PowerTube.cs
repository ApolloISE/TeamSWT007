﻿using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;

        private bool IsOn = false;
        public int MaxPower {
            set {
                if (value > 0 && value <= 1200)
                {
                    MaxPower = value;
                }
            }
        }

        public PowerTube(IOutput output, int maxPower)
        {
            myOutput = output;
            MaxPower = maxPower;
        }

        public void TurnOn(int power)
        {
            if (power < 1 || 700 < power)
            {
                throw new ArgumentOutOfRangeException("power", power, "Must be between 1 and 700 (incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}