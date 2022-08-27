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
                    await controller.Retrive(retrive);
                    Results.Ok();
                });

            app.MapPost("/invoice/ModifyPermission",
                async (ModifyPermissionDTO modify, IModifyController controller) =>
                {
                    await controller.Modify(modify);
                    Results.Ok();
                });

            app.MapPost("/invoice/RequestPermission",
                async (RequestPermissionDTO request, IRequestController controller) =>
                {
                    await controller.Request(request);
                    Results.Ok();
                });

            return app;
        }
    }
}
