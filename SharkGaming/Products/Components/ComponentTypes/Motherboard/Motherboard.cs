﻿namespace SharkGaming.Products.Components.ComponentTypes.Motherboard
{
    public class Motherboard : ComponentsClass
    {

        public bool SupportedRamIntergrityCheck { get; set; }
        public int MaxRamSize { get; set; }
        public string Technology { get; set; }
        public double BuSClock { get; set; }
        public string ProductType { get; set; }
        public string ChipsetType { get; set; }
        public string ProcessorSocket { get; set; }
        public string PowerConnectors { get; set; }
        public string BIOSType { get; set; }
        public double PCIExpress { get; set; }
        
        
        public Motherboard(string name, double price, bool amdCompatible, bool intelCompatible, string specInfo, bool supportedRamIntergrityCheck, int maxRamSize, string technology, double buSClock, string productType, string chipsetType, string processorSocket, string powerConnectors, string bIOSType, double pciExpress)
            : base(name, price, amdCompatible, intelCompatible, specInfo)
        {
            SupportedRamIntergrityCheck = supportedRamIntergrityCheck;
            MaxRamSize = maxRamSize;
            Technology = technology;
            BuSClock = buSClock;
            ProductType = productType;
            ChipsetType = chipsetType;
            ProcessorSocket = processorSocket;
            PowerConnectors = powerConnectors;
            BIOSType = bIOSType;
            PCIExpress = pciExpress;
        }

        public Motherboard()
        {

        }


      




    }
}
