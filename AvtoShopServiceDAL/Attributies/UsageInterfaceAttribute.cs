using System;

namespace AvtoShopServiceDAL.Attributies
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class UsageInterfaceAttribute : Attribute
    {
        public UsageInterfaceAttribute(string descript)
        {
            Description = string.Format("Описание интерфейса: ", descript);
        }
        public string Description { get; private set; }
    }
}
