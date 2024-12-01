using Aidan.Core.Errors;
using Aidan.Core.Patterns;
using Aidan.Web.AccessManagement.Extensions;
using Microsoft.AspNetCore.Http;

namespace Aidan.Web.AccessManagement.Services;

/// <summary>
/// Defines an interface for managing and retrieving authorization policies specific to web resources. <br/>
/// Implementations of this interface should determine the applicable authorization policy based on the provided HTTP context, <br/>
/// allowing for resource-specific access control decisions.
/// </summary>
public interface IAccessManagementService
{
    /// <summary>
    /// Asynchronously evaluates the authorization policy for a specific HTTP context, determining if the <br/>
    /// request is authorized to access the targeted resource. <br/>
    /// </summary>
    /// <param name="httpContext">The HTTP context for the current request. This context contains all <br/>
    /// the request information, including headers, cookies, and the requested path, which are used to <br/>
    /// evaluate the applicable authorization policy.</param>
    /// <returns>A task that represents the asynchronous evaluation operation. The task result is an <br/>
    /// <see cref="IResult"/>, indicating whether the request is authorized, denied, or requires <br/>
    /// further information (e.g., authentication challenge).</returns>
    /// <remarks>
    /// This method is crucial for enforcing security within a web application by ensuring that only <br/>
    /// authorized requests are allowed to proceed. Implementations should consider the request's context, <br/>
    /// such as the user's identity, roles, and any specific resource identifiers present in the request path <br/>
    /// or query strings, to make an informed authorization decision.
    /// </remarks>
    Task<Core.Patterns.IResult> AuthorizeAsync(HttpContext httpContext);

}

/* default concrete implementation */

/// <summary>
/// Provides an authorization service that leverages attributes to determine access control decisions for web resources.
/// </summary>
public class AccessManagementService : IAccessManagementService
{
    private IAccessPolicyService AccessPolicyService { get; }
    private IIdentityService IdentityService { get; }
    private Func<Error>? OnUnauthorized { get; }

    public AccessManagementService(
        IAccessPolicyService accessPolicyService,
        IIdentityService identityService,
        Func<Error>? onUnauthorized = null)
    {
        AccessPolicyService = accessPolicyService;
        IdentityService = identityService;
        OnUnauthorized = onUnauthorized;
    }

    /// <inheritdoc/>
    public async Task<Core.Patterns.IResult> AuthorizeAsync(HttpContext httpContext)
    {
        var accessPolicy = await AccessPolicyService.GetAccessPolicyAsync(httpContext);
        var identityResult = await IdentityService.GetIdentityAsync(httpContext);

        if (identityResult.IsFailure)
        {
            return identityResult;
        }

        var identity = identityResult.Data;

        if (identity is not null)
        {
            httpContext.SetIdentity(identity);
        }

        // If no identity is present or the access policy fails, return an unauthorized result.
        if (!accessPolicy.Authorize(identity))
        {
            return Result.Create()
                .Failure(GetUnauthorizedError());
        }

        // Return a successful authorization result.
        return Result.Create().Success();
    }

    private Error GetUnauthorizedError()
    {
        if (OnUnauthorized != null)
        {
            return OnUnauthorized.Invoke();
        }

        return new ErrorBuilder()
            .WithTitle("Unauthorized access.")
            .WithDescription("The user does not have permission to access this resource")
            .WithFlag(ErrorFlags.UserVisible)
            .Build();
    }

}
