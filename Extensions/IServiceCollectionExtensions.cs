using Aidan.Web.AccessManagement.Services;

namespace Aidan.Web.Extensions;

public static class IServiceCollectionExtensions
{
    /// <summary>
    /// Adds the <see cref="AccessManagementService"/> to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="accessPolicyService">The access policy service instance to use.</param>
    /// <param name="identityService">The identity service instance to use.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddAccessManagementService(
        this IServiceCollection services,
        IAccessPolicyService accessPolicyService,
        IIdentityService identityService)
    {
        // Instantiates the AccessManagementService with the provided dependencies.
        var service = new AccessManagementService(
            accessPolicyService,
            identityService);

        // Registers the instance as a singleton.
        return services.AddSingleton(service);
    }
}
