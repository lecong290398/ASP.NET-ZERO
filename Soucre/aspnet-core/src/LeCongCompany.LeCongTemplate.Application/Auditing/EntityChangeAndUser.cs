using Abp.EntityHistory;
using LeCongCompany.LeCongTemplate.Authorization.Users;

namespace LeCongCompany.LeCongTemplate.Auditing
{
    /// <summary>
    /// A helper class to store an <see cref="EntityChange"/> and a <see cref="User"/> object.
    /// </summary>
    public class EntityChangeAndUser
    {
        public EntityChange EntityChange { get; set; }

        public User User { get; set; }
    }
}