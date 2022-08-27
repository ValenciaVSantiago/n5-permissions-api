namespace N5.Permissions.SQLServer.Configurations
{
    internal class PermissionTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<PermissionType> builder)
        {
            builder
                .Property(c => c.PermissionTypeId)
                .IsRequired()
                .UseIdentityColumn();

            builder
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
