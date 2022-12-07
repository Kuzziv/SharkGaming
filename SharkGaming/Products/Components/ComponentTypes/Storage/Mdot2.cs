﻿namespace SharkGaming.Products.Components.ComponentTypes.Storage
{
    public class Mdot2 : StorageClass
    {
        public double PCIExpress { get; set; }

        public Mdot2()
        {

        }

        public Mdot2(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, int capacity, string compatibleBay, double internalDateRate, double pciExpress)
            : base(name, price, amdCompatible, intelCompatible, specInfo, capacity, compatibleBay, internalDateRate)
        {
            PCIExpress = pciExpress;
            Id = nextId++;
        }
    }
}
