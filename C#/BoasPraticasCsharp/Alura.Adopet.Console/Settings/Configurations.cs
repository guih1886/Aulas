using Microsoft.Extensions.Configuration;

namespace Alura.Adopet.Console.Settings
{
    public static class Configurations
    {
        public static IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddUserSecrets("a33eb90a-c9e3-4190-8db4-7ffa94657ac2")
                .Build();
        }

        public static ApiSettings ApiSetting
        {
            get
            {
                var _config = BuildConfiguration();
                return _config
                    .GetSection(ApiSettings.Section)
                    .Get<ApiSettings>() ??
                    throw new ArgumentException("Seção para configuração da API não encontrada!");
            }
        }

        public static MailSettings MailSetting
        {
            get
            {
                var _config = BuildConfiguration();
                return _config
                    .GetSection(MailSettings.EmailSection)
                    .Get<MailSettings>() ??
                    throw new ArgumentException("Seção para a configuração do e-mail não encontrada.");
            }
        }
    }
}