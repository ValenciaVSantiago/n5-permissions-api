namespace N5.Permissions.BusinessObjects.DTOs
{
    public class ModifyPermissionDTO
    {
        public int Id { get; set; }
        public string EmployeeForename { get; set; }
        public string EmployeeSurname { get; set; }
        public int PermissionTypeId { get; set; }
    }
}
