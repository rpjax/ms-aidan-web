using Aidan.Web.AccessManagement.Middlewares;

namespace Aidan.Web.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="IApplicationBuilder"/> to facilitate the integration of the IAM (Identity and Access Management) system.
/// </summary>
public static class IApplicationBuilderExtension
{
    /// <summary>
    /// Registers the IAM system and its middlewares into the application's request pipeline.
    /// </summary>
    /// <param name="builder">The application builder to which the middlewares should be added.</param>
    /// <returns>The updated <see cref="IApplicationBuilder"/> with the IAM system middlewares added.</returns>
    public static IApplicationBuilder UseAccessManagementService(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<AccessManagementMiddleware>();
    }

}
