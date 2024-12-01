using Microsoft.AspNetCore.Http;
using Aidan.Core;
using Aidan.Web.Attributes;
using Aidan.Core.Errors;
using Aidan.Core.Patterns;

namespace Aidan.Web;

public class AttributesHandlerMiddleware : Middleware
{
    public AttributesHandlerMiddleware(RequestDelegate next) : base(next)
    {
    }

    protected override async Task<Strategy> BeforeNextAsync(HttpContext context)
    {
        var endpoint = context.GetEndpoint();

        if (endpoint == null)
        {
            return Strategy.Continue;
        }

        var forbbidenActionAttribute = endpoint.Metadata.GetMetadata<ForbbidenActionAttribute>();

        if (forbbidenActionAttribute != null)
        {
            var error = Error.Create()
                .WithTitle("This operation is forbidden.")
                .WithFlag(ErrorFlags.UserVisible)
                .Build();

            var result = new Result(error);

            await context.WriteOperationResponseAsync(result, 403);

            return Strategy.Break;
        }

        return Strategy.Continue;
    }

}
