﻿
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components;
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Products;
using SharkGaming.MockData.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.MockData.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.MockData.Products.Components.ComponentTypes.GPU;
using SharkGaming.MockData.Products.Components.ComponentTypes.CPU;
using SharkGaming.MockData.Products.Components.ComponentTypes.Case;
using SharkGaming.MockData.Products.CustomPC;
using SharkGaming.MockData.Products.PreBuilds;
using SharkGaming.MockData.Products;
using SharkGaming.MockData.Products.Components.ComponentTypes.Ram;
using SharkGaming.MockData.Products.Components;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MStorage;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes.MCooling;

namespace SharkGaming.Services.ProductServiceFile
{
    public class ProductService : IProductService
    {
        #region Lists
        private List<ProductsClass> _products;
        private List<ComponentsClass> _components;
        private List<PreBuildsClass> _preBuilds;
        private List<CustomPcClass> _customPcs;
        private List<Cases> _cases;
        private List<CoolingClass> _cooling;
        private List<CaseFan> _caseFans;
        private List<CPUCooling> _cPUCooling;
        private List<CPUAirCooling> _cPUAirCooling;
        private List<CPUWaterCooling> _cPUWaterCooling;
        private List<CPU> _cPUs;
        private List<GPU> _gPUs;
        private List<Motherboard> _motherboards;
        private List<PowerSupply> _powerSupplies;
        private List<StorageClass> _storage;
        private List<RAM> _rAMs;
        private List<Mdot2> _mdot2s;
        private List<SolidStateDrive> _solidStateDrives;
        #endregion

        #region initialise Lists
        public ProductService()
        {
            //_products = MockProducts.GetMockProducts();
            _components = MockComponents.GetMockComponentsClass();
            //_preBuilds = MockPreBuilds.GetMockPreBuilds();
            //_customPcs = MockCustomPC.GetMockCustomPcs();
            _cases = MockCaseS.GetMockCases();
            _cooling = MockCooling.GetMockCooling();
            _caseFans = MockCaseFan.GetMockCaseFans();
            _cPUAirCooling = MockCPUAirCooling.GetMockCPUAirCoolings();
            _cPUWaterCooling = MockCPUWaterCooling.GetMockCPUWaterCooling();
            _cPUs = MockCPU.GetMockCPUs();
            _gPUs = MockGPU.GetMockGPUs();
            _motherboards = MockMotherboard.GetMockMotherboards();
            _powerSupplies = MockPowerSupply.GetMockPowerSupplies();
            _storage = MockStorage.GetMockStorage();
            _rAMs = MockRam.GetMockRam();
            _mdot2s = MockMdot.GetMockMdot2s();
            _solidStateDrives = MockSolidStateDrive.GetMockSoildSateDrives();
        }
        #endregion

        #region Get methods
        public List<ProductsClass> GetAllProducts()
        {
            return _products;
        }
        public List<ComponentsClass> GetAllComponents()
        {
            return _components;
        }
        public List<PreBuildsClass> GetPreBuilds()
        {
            return _preBuilds;
        }
        public List<CustomPcClass> GetCustomPc()
        {
            return _customPcs;
        }
        public List<Cases> GetCases()
        {
            return _cases;
        }
        public List<CoolingClass> GetAllCooling()
        {
            return _cooling;
        }
        public List<CaseFan> GetCaseFans()
        {
            return _caseFans;
        }
        public List<CPUCooling> GetCPUCooling()
        {
            return _cPUCooling;
        }
        public List<CPUAirCooling> GetCPUAirCooling()
        {
            return _cPUAirCooling;
        }
        public List<CPUWaterCooling> GetCPUWaterCooling()
        {
            return _cPUWaterCooling;
        }
        public List<CPU> GetCPUs()
        {
            return _cPUs;
        }
        public List<GPU> GetGPUs()
        {
            return _gPUs;
        }
        public List<Motherboard> GetMotherboards()
        {
            return _motherboards;
        }
        public List<PowerSupply> GetPowerSupply()
        {
            return _powerSupplies;
        }
        public List<RAM> GetRAM()
        {
            return _rAMs;
        }
        public List<StorageClass> GetStorage()
        {
            return _storage;
        }
        public List<Mdot2> GetMdot2()
        {
            return _mdot2s;
        }
        public List<SolidStateDrive> GetSolidStateDrives()
        {
            return _solidStateDrives;
        }
        #endregion

        #region Add to list methods
        public void AddProduct(ProductsClass product)
        {
            _products.Add(product);
            //JsonServiceFile.JsonService.SaveJsonItems(_products);
        }
        public void AddComponent(ComponentsClass comp)
        {
            _components.Add(comp);
            //JsonServiceFile.JsonService.SaveJsonItems(_components);
        }
        public void AddPreBuild(PreBuildsClass preBuilds)
        {
            _preBuilds.Add(preBuilds);
            //JsonServiceFile.JsonService.SaveJsonItems(_preBuilds);
        }
        public void AddCustomPc(CustomPcClass customPc)
        {
            _customPcs.Add(customPc);
            //JsonServiceFile.JsonService.SaveJsonItems(_customPcs);
        }
        public void AddCase(Cases cas)
        {
            _cases.Add(cas);
            //JsonServiceFile.JsonService.SaveJsonItems(_cases);
        }
        public void AddCooling(CoolingClass cooling)
        {
            _cooling.Add(cooling);
            //JsonServiceFile.JsonService.SaveJsonItems(_cooling);
        }
        public void AddCaseFan(CaseFan caseFan)
        {
            _caseFans.Add(caseFan);
            //JsonServiceFile.JsonService.SaveJsonItems(_caseFans);
        }
        public void AddCPUCooling(CPUCooling cpuCooling)
        {
            _cPUCooling.Add(cpuCooling);
            //JsonServiceFile.JsonService.SaveJsonItems(_cPUCooling);
        }
        public void AddCPUAirCooling(CPUAirCooling air)
        {
            _cPUAirCooling.Add(air);
            //JsonServiceFile.JsonService.SaveJsonItems(_cPUAirCooling);
        }
        public void AddCPUWaterCooling(CPUWaterCooling water)
        {
            _cPUWaterCooling.Add(water);
            //JsonServiceFile.JsonService.SaveJsonItems(_cPUWaterCooling);
        }
        public void AddCPU(CPU cpu)
        {
            _cPUs.Add(cpu);
            //JsonServiceFile.JsonService.SaveJsonItems(_cPUs);
        }
        public void AddGPU(GPU gpu)
        {
            _gPUs.Add(gpu);
            //JsonServiceFile.JsonService.SaveJsonItems(_gPUs);
        }
        public void AddMotherboard(Motherboard motherboard)
        {
            _motherboards.Add(motherboard);
            //JsonServiceFile.JsonService.SaveJsonItems(_motherboards);
        }
        public void AddPowerSupply(PowerSupply psu)
        {
            _powerSupplies.Add(psu);
            //JsonServiceFile.JsonService.SaveJsonItems(_powerSupplies);
        }
        public void AddRAM(RAM ram)
        {
            _rAMs.Add(ram);
            //JsonServiceFile.JsonService.SaveJsonItems(_rAMs);
        }
        public void AddStorage(StorageClass storage)
        {
            _storage.Add(storage);
            //JsonServiceFile.JsonService.SaveJsonItems(_storage);
        }
        public void AddMdot2(Mdot2 mdot2)
        {
            _mdot2s.Add(mdot2);
            //JsonServiceFile.JsonService.SaveJsonItems(_mdot2s);
        }
        public void AddSolidStateDrive(SolidStateDrive ssd)
        {
            _solidStateDrives.Add(ssd);
            //JsonServiceFile.JsonService.SaveJsonItems(_solidStateDrives);
        }

        #endregion

        #region Name Search
        public IEnumerable<ProductsClass> ProductNameSearch(string str)
        {
            List<ProductsClass> nameSearch = new List<ProductsClass>();
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    foreach (ProductsClass item in _products)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                }
                return nameSearch;
            }
        }
        public IEnumerable<ComponentsClass> ComponentNameSearch(string str)
        {
            List<ComponentsClass> nameSearch = new List<ComponentsClass>();
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    foreach (ComponentsClass item in _components)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                }
                return nameSearch;
            }
        }
        #endregion

        #region update product
        public void UpdateProduct(ProductsClass item)
        {
            if (item != null)
            {
                foreach (ProductsClass i in _products)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                }
            }
        }
        #endregion

        #region price filter
        public IEnumerable<ProductsClass> PriceFilter(double maxPrice, double minPrice = 0)
        {
            List<ProductsClass> filterList = new List<ProductsClass>();
            foreach (ProductsClass item in _products)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            return filterList;
        }
        #endregion

        #region Get Product via ID
        public ProductsClass GetProduct(int id)
        {
            if (id != null)
            {
                foreach (ProductsClass i in _products)
                    if (i.Id == id)
                    {
                        return i;
                    }
            }
            return null;
        }
        #endregion
       
        #region Delete Product
        public ProductsClass DeleteProduct(int? itemId)
        {
            #region Delete Product
            ProductsClass productToBeDeleted = null;
            foreach (ProductsClass item in _products)
            {
                if (item.Id == itemId)
                {
                    productToBeDeleted = item;
                    break;
                }
            }
            if (productToBeDeleted != null)
            {
                _products.Remove(productToBeDeleted);
                //JsonServiceFile.JsonService.SaveJsonItems(_products);
            }
            #endregion

            #region Delete Component
            ComponentsClass componentToBeDeleted = null;
            foreach (ComponentsClass item in _components)
            {
                if (item.Id == itemId)
                {
                    componentToBeDeleted = item;
                    break;
                }
            }
            if (componentToBeDeleted != null)
            {
                _components.Remove(componentToBeDeleted);
                //JsonServiceFile.JsonService.SaveJsonItems(_products);
            }
            #endregion

            #region Delete Pre Build
            PreBuildsClass preBuildToBeDeleted = null;
            foreach (PreBuildsClass item in _preBuilds)
            {
                if (item.Id == itemId)
                {
                    preBuildToBeDeleted = item;
                    break;
                }
            }
            if (preBuildToBeDeleted != null)
            {
                _preBuilds.Remove(preBuildToBeDeleted);
                //JsonServiceFile.JsonService.SaveJsonItems(_products);
            }
            #endregion

            #region Delete Case
            Cases caseToBeDeleted = null;
            foreach (Cases item in _cases)
            {
                if (item.Id == itemId)
                {
                    caseToBeDeleted = item;
                    break;
                }
            }
            if (caseToBeDeleted != null)
            {
                _cases.Remove(caseToBeDeleted);
                //JsonServiceFile.JsonService.SaveJsonItems(_products);
            }
            #endregion

            #region Delete Cooling
            CoolingClass coolingToBeDeleted = null;
            foreach (CoolingClass item in _cooling)
            {
                if (item.Id == itemId)
                {
                    coolingToBeDeleted = item;
                    break;
                }
            }
            if (coolingToBeDeleted != null)
            {
                _cooling.Remove(coolingToBeDeleted);
                //JsonServiceFile.JsonService.SaveJsonItems(_products);
            }
            #endregion
            
            #region Delete CaseFan
            CaseFan caseFanToBeDeleted = null;
            foreach (CaseFan item in _caseFans)
            {
                if (item.Id == itemId)
                {
                    caseFanToBeDeleted = item;
                    break;
                }
            }
            if (caseFanToBeDeleted != null)
            {
                _caseFans.Remove(caseFanToBeDeleted);
                //JsonServiceFile.JsonService.SaveJsonItems(_products);
            }
            #endregion


            return productToBeDeleted;
        }
        #endregion
    }
}
