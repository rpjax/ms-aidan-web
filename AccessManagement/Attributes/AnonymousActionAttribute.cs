namespace Aidan.Web.AccessManagement.Attributes;

/// <summary>
/// Marks an action method as exempt from the application's general access control policies, allowing unrestricted access. <br/>
/// This attribute effectively nullifies the effect of <see cref="AuthorizeControllerAttribute"/> and <see cref="AuthorizeActionAttribute"/> on the marked action.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class AnonymousActionAttribute : AccessManagementAttribute
{
    public override IAccessPolicy GetAccessPolicy()
    {
        return new AccessPolicy();
    }
}
