namespace ResourceSystem
{
    public class Resource
    {
        public int ResourceAmount { get; private set; }
        public ResourceType ResourceType { get; private set; }
        public Resource(ResourceType resourceType, int startValue)
        {
            ResourceType = resourceType;
            ResourceAmount = startValue;
        }
        public void AddResource(int value)
        {
            ResourceAmount += value;
        }
    }
}