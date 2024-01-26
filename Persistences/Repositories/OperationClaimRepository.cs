using Application.Services.Repositories;
using Core.Packages.Repositories;
using Core.Security.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class OperationClaimRepository : EfRepositoryBase<OperationClaim, int, BaseDbContext>, IOperationClaimRepository
{
    public OperationClaimRepository(BaseDbContext context) : base(context)
    {
    }
}