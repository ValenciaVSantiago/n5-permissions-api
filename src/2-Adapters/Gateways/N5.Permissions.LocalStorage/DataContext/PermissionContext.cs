namespace N5.Permissions.SQLServer.DataContext
{
    // Add-Migration InitialCreate -p N5.Permissions.SQLServer -s N5.Permissions.SQLServer -c PermissionContext
    // Update-Database -p N5.Permissions.SQLServer -s N5.Permissions.SQLServer -context PermissionContext

    internal class PermissionContext : DbContext
    {
        public PermissionContext(DbContextOptions<PermissionContext> options)
            : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=n5-employees;Persist Security Info=True;User Id=Sa;Password=12345Abc%;MultipleActiveResultSets=True;Connection Timeout=30;");
        //}

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
