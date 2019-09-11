using System;

namespace AvtoShopServiceDAL.Attributies
{
    [AttributeUsage(AttributeTargets.Method)]
    public class UsageMethodAttribute : Attribute
    {
        public UsageMethodAttribute(string descript)
        {
            Description = string.Format("Описание метода: ", descript);
        }
        public string Description { get; private set; }
    }
}
