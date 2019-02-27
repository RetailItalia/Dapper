using System.Reflection;

namespace Dapper.Contrib.Extensions
{
    public interface IAliasPropertyMap
    {
        PropertyInfo GetPropertyMap(string name);
    }
    public interface IAliasColumnMap
    {
        string GetColumnName(PropertyInfo property);

    }
}
