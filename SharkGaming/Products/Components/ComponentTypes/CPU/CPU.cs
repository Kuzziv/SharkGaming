﻿namespace SharkGaming.Products.Components.ComponentTypes.CPU
{
    public class CPU : ComponentsClass
    {
        public double ClockSpeed { get; set; }
        public double BoostClock { get; set; }
        public int Core { get; set; }
        public int Threads { get; set; }
        public string Socket { get; set; }
        public bool UnlockForOC { get; set; }
        public double PCIExpress { get; set; }
        public int ThermalDesignPower { get; set; }


        public CPU(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, double clockSpeed, double boostClock, int core, int threads, string socket, bool unlockForOC, double pCIExpress, int thermalDesignPower)
            : base(name, price, amdCompatible, intelCompatible, specInfo)
        {
            ClockSpeed = clockSpeed;
            BoostClock = boostClock;
            Core = core;
            Threads = threads;
            Socket = socket;
            UnlockForOC = unlockForOC;
            PCIExpress = pCIExpress;
            ThermalDesignPower = thermalDesignPower;
            Id = nextId++;
        }
        
        public CPU()
        {

        }

    }
}
