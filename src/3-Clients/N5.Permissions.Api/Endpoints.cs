namespace N5.Permissions.Api
{
    public static class Endpoints
    {
        public static WebApplication UseWebsiteEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => "¡Welcome to Permissions Api!");

            app.MapGet("/invoice/RetrivePermission",
                async (int retrive, IRetriveController controller) =>
                {
                    var result = await controller.Retrive(retrive);
                    return Results.Ok(result);
                });

            app.MapPost("/invoice/ModifyPermission",
                async (ModifyPermissionDTO modify, IModifyController controller) =>
                {
                    await controller.Modify(modify);
                    return Results.Ok();
                });

            app.MapPost("/invoice/RequestPermission",
                async (RequestPermissionDTO request, IRequestController controller) =>
                {
                    await controller.Request(request);
                    return Results.Ok();
                });

            return app;
        }
    }
}
