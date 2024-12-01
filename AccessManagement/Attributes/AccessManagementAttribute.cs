namespace Aidan.Web.AccessManagement.Attributes;

/// <summary>
/// Serves as a base for attributes related to access management within an ASP.NET Core application. <br/>
/// This abstract class is the foundation for attributes that control access to controllers and action methods <br/>
/// based on authorization policies or exclusion from such policies.
/// </summary>
public abstract class AccessManagementAttribute : Attribute
{
    public abstract IAccessPolicy GetAccessPolicy();
}
