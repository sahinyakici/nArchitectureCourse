using Application.Services.Repositories;
using Core.Packages.Repositories;
using Core.Security.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class UserRepository : EfRepositoryBase<User, int, BaseDbContext>, IUserRepository
{
    public UserRepository(BaseDbContext context) : base(context)
    {
    }
}