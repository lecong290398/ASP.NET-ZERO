using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace LeCongCompany.LeCongTemplate.Net.Emailing
{
    public class LeCongTemplateSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public LeCongTemplateSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}