using Volo.Abp.Reflection;

namespace EZCode.ProductService.Permissions;

public class ProductServicePermissions
{
    public const string GroupName = "ProductService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductServicePermissions));
    }

    public static class Products
    {
        public const string Default = GroupName + ".Products";
        public const string Create = Default + ".Create";
    }
}
