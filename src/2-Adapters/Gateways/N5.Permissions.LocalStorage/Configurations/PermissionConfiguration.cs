namespace N5.Permissions.SQLServer.Configurations
{
    internal class PermissionConfiguration
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder
                .Property(c => c.Id)
                .IsRequired()
                .UseIdentityColumn();

            builder
                .Property(c => c.EmployeeForename)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(c => c.EmployeeSurname)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(c => c.PermissionTypeId)
                .IsRequired();

            builder
                .Property(c => c.PermissionDate)
                .IsRequired();
        }
    }
}
