using LeCongCompany.LeCongTemplate.EntityFrameworkCore;

namespace LeCongCompany.LeCongTemplate.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly LeCongTemplateDbContext _context;

        public InitialHostDbBuilder(LeCongTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new InitialPeopleCreator(_context).Create();
            new InitialPeopleAndPhoneCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
