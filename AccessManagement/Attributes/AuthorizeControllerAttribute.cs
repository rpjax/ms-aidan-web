namespace Aidan.Web.AccessManagement.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class AuthorizeControllerAttribute : AccessManagementAttribute
{
    public string Permission { get; }

    public AuthorizeControllerAttribute(string permission)
    {
        Permission = permission;
    }

    public override IAccessPolicy GetAccessPolicy()
    {
        return new AccessPolicyBuilder()
            .AddRequiredPermission(new IdentityPermission(Permission))
            .Build();
    }
}
