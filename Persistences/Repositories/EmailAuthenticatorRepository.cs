using Application.Services.Repositories;
using Core.Packages.Repositories;
using Core.Security.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class EmailAuthenticatorRepository : EfRepositoryBase<EmailAuthenticator, int, BaseDbContext>,
    IEmailAuthenticatorRepository
{
    public EmailAuthenticatorRepository(BaseDbContext context) : base(context)
    {
    }
}