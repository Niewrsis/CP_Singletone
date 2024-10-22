using System;
using System.Collections.Generic;

namespace ResourceSystem
{
    public class ResourceBank
    {

        private const int _startResourcesValue = 0;
        private Dictionary<ResourceType, Resource> _resources;

        public ResourceBank()
        {
            InitResources();
        }
        private static ResourceBank instance = null;
        public static ResourceBank Instance
        {
            get
            {
                if(instance == null)
                    instance = new();

                return instance;
            }
        }

        private void InitResources()
        {
            _resources = new();

            for (int i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
            {
                Resource newResources = new((ResourceType)i, _startResourcesValue);
                _resources.Add((ResourceType)i, newResources);
            }
        }
        public int GetResourceAmount(ResourceType resourceType)
        {
            if (_resources.ContainsKey(resourceType))
            {
                return _resources[resourceType].ResourceAmount;
            }
            return 0;
        }

        public void AddResources(ResourceType resourceType, int amount)
        {
            _resources[resourceType].AddResource(amount);
        }
    }
}