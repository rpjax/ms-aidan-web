namespace Aidan.Web.AccessManagement.Attributes;

/// <summary>
/// Specifies authorization policies for a specific action method within a controller. <br/>
/// When applied, it requires that the caller meets the specified authorization criteria to execute the action.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class AuthorizeActionAttribute : AccessManagementAttribute
{
    public string Permission { get; }

    public AuthorizeActionAttribute(string permission)
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
