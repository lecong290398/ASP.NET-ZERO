namespace LeCongCompany.LeCongTemplate.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}