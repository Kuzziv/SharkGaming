﻿using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MCooling
{
    public class MockCPUAirCooling
    {
        private static List<CPUAirCooling> _cPUAirCoolers = new List<CPUAirCooling>()
        {
            new CPUAirCooling("Arctic Freezer 34 eSports", 399, true, true, "Great at cooling your CPU" ,"Aluminium",true, "Intel: 1700, 1200, 1155, 1151, 1150, 2066, 2011(-3) AMD: AM5, AM4", 6, 0.6, 120, "4-pin", "1,70", 2100, "1.75m3/h", "00", "Black" ),
            new CPUAirCooling("NOCTUA NH-U12S REDUX CPU COOLER", 449, true, true, "Great at cooling your CPU" ,"Nickel plated Copper (base and heat-pipes), aluminium (cooling fins)",true, "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700, LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM4", 6, 0.6, 120.2, "4-pin", "1,70", 1700, "1.20m3/h", "00", "Black" ),
            new CPUAirCooling("NOCTUA NH-U9S CHROMAX.BLACK CPU COOLER", 619, true, true, "Great at cooling your CPU" ,"Copper (base and heat-pipes), aluminium (cooling fins), soldered joints & nickel plating",true, "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1700, LGA1200 LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM2, AM2+, AM3, AM3+, FM1, FM2, FM2+ (backplate required), AM4", 6, 0.6, 120, "4-pin", "78,9", 2000, "1.75m2/h", "00", "Black" )
        };

        public static List<CPUAirCooling> GetMockCPUAirCoolings()
        {
            return _cPUAirCoolers;
        }
    }
    
}
