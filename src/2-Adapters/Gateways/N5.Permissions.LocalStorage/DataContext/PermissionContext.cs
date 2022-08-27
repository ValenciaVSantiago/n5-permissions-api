namespace N5.Permissions.SQLServer.DataContext
{
    // Add-Migration InitialCreate -p N5.Permissions.SQLServer -s N5.Permissions.SQLServer -c PermissionContext
    // Update-Database -p N5.Permissions.SQLServer -s N5.Permissions.SQLServer -context PermissionContext

    internal class PermissionContext : DbContext
    {
        public PermissionContext(DbContextOptions<PermissionContext> options)
            : base(options) { }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
