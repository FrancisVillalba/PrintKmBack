namespace PrintKmBack.Security;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class SkipPermissionAttribute : Attribute
{
}
