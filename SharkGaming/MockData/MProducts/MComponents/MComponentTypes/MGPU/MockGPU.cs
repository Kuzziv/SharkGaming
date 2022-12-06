﻿using SharkGaming.Products.Components.ComponentTypes.GPU;

namespace SharkGaming.MockData.Products.Components.ComponentTypes.GPU
{
    public class MockGPU
    {
        public static List<SharkGaming.Products.Components.ComponentTypes.GPU.GPU> _GPU = new List<SharkGaming.Products.Components.ComponentTypes.GPU.GPU>
        {
            new SharkGaming.Products.Components.ComponentTypes.GPU.GPU("ASUS GeForce RTX 3090 TI", 13799.45, true, true, "Top of the line PCI4 GPU", "NVIDIA GeForce RTX 3090 TI", 10752, true, "7680 x 4320", 24000, "GDDR6X SDRAM", 384, 1000, 32.59, 4.0),
            new SharkGaming.Products.Components.ComponentTypes.GPU.GPU("Gigabyte GeForce RTX 3070 TI", 5605.89, true, true, "Mid-end GPU", "NVIDIA GeForce RTX 3070 TI", 6144, true, "7680 x 4320", 8000, "GDDR6X SDRAM", 256, 850, 29.49, 4.0),
            new SharkGaming.Products.Components.ComponentTypes.GPU.GPU("MSI GeForce RTX 3060 TI Ventus", 3881.03, true, true, "Low-end GPU", "NVIDIA GeForce RTX 3060 TI", 4864, true, "7680 x 4320", 8000, "GDDR6X SDRAM", 256, 600, 21.31, 4.0)
        };

        public static List<SharkGaming.Products.Components.ComponentTypes.GPU.GPU> GetMockGPUs()
        {
            return _GPU;
        }

    }
}
