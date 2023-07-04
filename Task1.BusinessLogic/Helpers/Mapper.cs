using System.Linq;

namespace Task1.BusinessLogic.Helpers
{
    public static class Mapper
    {
        public static T2 Map<T1, T2>(T1 source) where T2 : new()
        {
            var result = new T2();
            var propertiesT1 = typeof(T1).GetProperties();
            var propertiesT2 = typeof(T2).GetProperties();

            foreach(var property in propertiesT1)
            {
                if (propertiesT2.Any(prop => prop.Name == property.Name && prop.PropertyType.Equals(property.PropertyType)))
                {
                    propertiesT2.First(prop => prop.Name == property.Name).SetValue(result, property.GetValue(source));
                }
            }
            return result;
        }
    }
}
