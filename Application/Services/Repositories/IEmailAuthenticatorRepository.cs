using Core.Packages.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories;

public interface IEmailAuthenticatorRepository : IAsyncRepository<EmailAuthenticator, int>,
    IRepository<EmailAuthenticator, int>
{
}