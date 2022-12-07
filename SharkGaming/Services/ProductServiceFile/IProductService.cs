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
        List<ProductsClass> GetAllProducts();
        List<ComponentsClass> GetAllComponents();
        List<PreBuildsClass> GetPreBuilds();
        List<CustomPcClass> GetCustomPc();
        List<Cases> GetCases();
        List<CoolingClass> GetAllCooling();
        List<CaseFan> GetCaseFans();
        List<CPUCooling> GetCPUCooling();
        List<CPUAirCooling> GetCPUAirCooling();
        List<CPUWaterCooling> GetCPUWaterCooling();
        List<CPU> GetCPUs();
        List<GPU> GetGPUs();
        List<Motherboard> GetMotherboards();
        List<PowerSupply> GetPowerSupply();
        List<RAM> GetRAM();
        List<StorageClass> GetStorage();
        List<Mdot2> GetMdot2();
        List<SolidStateDrive> GetSolidStateDrives();
        #endregion

        #region Add Item methods
        void AddProduct(ProductsClass product);
        void AddComponent(ComponentsClass comp);
        void AddPreBuild(PreBuildsClass preBuilds);
        void AddCustomPc(CustomPcClass customPc);
        void AddCase(Cases cas);
        void AddCooling(CoolingClass cooling);
        void AddCaseFan(CaseFan caseFan);
        void AddCPUCooling(CPUCooling cpuCooling);
        void AddCPUAirCooling(CPUAirCooling air);
        void AddCPUWaterCooling(CPUWaterCooling water);
        void AddCPU(CPU cpu);
        void AddGPU(GPU gpu);
        void AddMotherboard(Motherboard motherboard);
        void AddPowerSupply(PowerSupply psu);
        void AddRAM(RAM ram);
        void AddStorage(StorageClass storage);
        void AddMdot2(Mdot2 mdot2);
        void AddSolidStateDrive(SolidStateDrive ssd);
        #endregion

        #region Name Search Methods
        IEnumerable<ProductsClass> ProductNameSearch(string str);
        IEnumerable<ComponentsClass> ComponentNameSearch(string str);
        #endregion

        #region Price Filter 
        IEnumerable<ProductsClass> PriceFilter(double maxPrice, double minPrice = 0);
        #endregion

        #region Update Product
        void UpdateProduct(ProductsClass item);
        #endregion

        #region Get Product via ID
        ProductsClass GetProduct(int id);
        #endregion

        #region Delete Product
        ProductsClass DeleteProduct(int? productId);
        #endregion
    }
}
