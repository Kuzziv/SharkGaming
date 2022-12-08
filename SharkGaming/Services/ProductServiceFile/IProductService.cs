﻿using SharkGaming.Products;
using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;

namespace SharkGaming.Services.ProductServiceFile
{
    public interface IProductService
    {
        #region Get list methods    
        List<ProductsClass> GetPreBuilds();
        List<CustomPcClass> GetCustomPc();
        List<Cases> GetCases();
        List<CaseFan> GetCaseFan();
        List<CPUAirCooling> GetCPUAirCooling();
        List<CPUWaterCooling> GetCPUWaterCooling();
        List<CPU> GetCPUs();
        List<GPU> GetGPUs();
        List<Motherboard> GetMotherboards();
        List<PowerSupply> GetPowerSupply();
        List<RAM> GetRAM();
        List<Mdot2> GetMdot2();
        List<SolidStateDrive> GetSolidStateDrives();
        #endregion

        #region Add Item methods
        void AddPreBuild(ProductsClass preBuilds);
        void AddCustomPc(CustomPcClass customPc);
        void AddCase(Cases cas);
        void AddCaseFan(CaseFan caseFan);
        void AddCPUAirCooling(CPUAirCooling air);
        void AddCPUWaterCooling(CPUWaterCooling water);
        void AddCPU(CPU cpu);
        void AddGPU(GPU gpu);
        void AddMotherboard(Motherboard motherboard);
        void AddPowerSupply(PowerSupply psu);
        void AddRAM(RAM ram);
        void AddMdot2(Mdot2 mdot2);
        void AddSolidStateDrive(SolidStateDrive ssd);
        #endregion

        #region Name Search Methods
        IEnumerable<ProductsClass> ProductNameSearch(string str);
        #endregion

        #region Price Filter 
        IEnumerable<ProductsClass> PriceFilter(double maxPrice, double minPrice = 0);
        #endregion

        #region Update Product
        void UpdatePreBuilds(ProductsClass productsClass);
        void UpdateCase(Cases cases);
        void UpdateCaseFan(CaseFan caseFan);
        void UpdateCPUAirCooling(CPUAirCooling airCooling);
        void UpdateCPUWaterCooling(CPUWaterCooling waterCooling);
        void UpdateCPU(CPU cpu);
        void UpdateGPU(GPU gpu);
        void UpdateMotherboards(Motherboard motherboard);
        void UpdatePowerSupply(PowerSupply powerSupply);
        void UpdateMdot2(Mdot2 mdot2);
        void UpdateRAM(RAM ram);
        void UpdateSSD(SolidStateDrive solidStateDrive);

        #endregion

        #region Get Product via ID
        ProductsClass GetProduct(int id);
        #endregion

        #region Delete Product
        ProductsClass DeleteProduct(int? productId);
        #endregion


        Cases GetCases(int id);
        CaseFan GetCaseFans(int id);
        CPUAirCooling GetCPUAirCoolings(int id);
        CPUWaterCooling GetCPUWaterCoolings(int id);
        CPU GetCPUs(int id);
        GPU GetGPUs(int id);
        Motherboard GetMotherboards(int id);
        PowerSupply GetPowerSupplys(int id);
        Mdot2 GetMdot2s(int id);
        SolidStateDrive GetSolidStateDrives(int id);
        RAM GetRAMs(int id);

    }
}
