using System.Threading.Tasks;
using lab.Domain;
using lab.Domain.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace lab.Domain.Services {
    public class MailService : IMailService {
        public MailService()
        {
        }

        // private readonly JHipsterSettings _jhipsterSettings;
        
        // public MailService(IOptions<JHipsterSettings> jhipsterSettings)
        // {
        //     _jhipsterSettings = jhipsterSettings.Value;
        // }

        public Task SendPasswordResetMail(User user)
        {
            //TODO send reset Email
            return Task.FromResult(Task.CompletedTask);
        }

        public Task SendActivationEmail(User user)
        {
            //TODO Activation Email
            return Task.FromResult(Task.CompletedTask);
        }

        public Task SendCreationEmail(User user)
        {
            //TODO Creation Email
            return Task.FromResult(Task.CompletedTask);
        }
    }
}
