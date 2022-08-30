namespace N5.Permissions.SQLServer.Repositories
{
    internal class PermissionsRepository : IPermissionsRepository
    {
        private readonly PermissionContext Context;

        public PermissionsRepository(PermissionContext context)
        {
            Context = context;
        }

        public async ValueTask<Permission> GetPermissionsById(int id)
        {
            try
            {
                return await Context.Permissions.FirstAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                log(ex.Message);
                throw;
            }        
        }

        public async ValueTask AddPermissions(Permission permission)
        {
            try
            {
                await Context.Permissions.AddAsync(permission);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                log(ex.Message);
                throw;
            }
        }

        public async ValueTask ModifyPermissions(Permission permission)
        {
            try
            {
                Context.Entry(await Context.Permissions.FirstAsync(x => x.Id == permission.Id)).CurrentValues.SetValues(permission);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                log(ex.Message);
                throw;
            }
        }

        private void log(string message) 
        {
            using (var log = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger())
            {
                log.Warning(message);
            }
        }
    }
}
