using Application.Services.Repositories;
using Core.Packages.Repositories;
using Core.Security.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class OtpAuthenticatorRepository : EfRepositoryBase<OtpAuthenticator, int, BaseDbContext>,
    IOtpAuthenticatorRepository
{
    public OtpAuthenticatorRepository(BaseDbContext context) : base(context)
    {
    }
}